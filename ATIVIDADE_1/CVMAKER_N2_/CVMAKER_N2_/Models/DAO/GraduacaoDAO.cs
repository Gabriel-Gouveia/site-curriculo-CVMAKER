using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class GraduacaoDAO
    {
        public void Inserir(GraduacaoViewModel formacao)
        {
            string sql = "insert into FormacaoGraduacao(idFormacao_G, idCurriculo_G, instituicao_G, periodo_G, turno_G, nome_G, Tipo_G, cidade_G, uf_G, inicio_G, fim_G)" +
                "values (@idFormacao_G, @idCurriculo_G, @instituicao_G, @periodo_G, @turno_G, @nome_G, @Tipo_G, @cidade_G, @uf_G, @inicio_G, @fim_G)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }

        public void Alterar(GraduacaoViewModel formacao)
        {
            string sql = "update FormacaoGraduacao set instituicao_G = @instituicao_G, " + "periodo_G = @periodo_G, " + "turno_G = @turno_G, " + "nome_G = @nome_G, "
                + "Tipo_G = @Tipo_G, "
                + "cidade_G = @cidade_G, " + "uf_G = @uf_G, " + "inicio_G = @inicio_G, " + "fim_G = @fim_G where idFormacao_G = @idFormacao_G";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }


        private SqlParameter[] CriaParametros(GraduacaoViewModel formacao)
        {
            SqlParameter[] parametros = new SqlParameter[11];
            parametros[0] = new SqlParameter("idFormacao_G", formacao.IdFormacao);
            parametros[1] = new SqlParameter("idCurriculo_G", formacao.IdCurriculo);
            parametros[2] = new SqlParameter("instituicao_G", formacao.Instituicao);
            parametros[3] = new SqlParameter("periodo_G", formacao.Periodo);
            parametros[4] = new SqlParameter("turno_G", formacao.Turno);
            parametros[5] = new SqlParameter("nome_G", formacao.Curso);
            parametros[6] = new SqlParameter("Tipo_G", formacao.Tipo);
            parametros[7] = new SqlParameter("cidade_G", formacao.Cidade);
            parametros[8] = new SqlParameter("uf_G", formacao.Uf);
            parametros[9] = new SqlParameter("inicio_G", formacao.Inicio);
            parametros[10] = new SqlParameter("fim_G", formacao.Conclusao);
            return parametros;
        }

        public void Excluir(int id)
        {
            string sql = "delete FormacaoGraduacao where idFormacao_G =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(idFormacao_G) +1, 1) as 'Maior' from FormacaoGraduacao";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}
