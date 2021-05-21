using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class PosGraduacaoDAO
    {
        public void Inserir(PosGraduacaoViewModel formacao)
        {
            string sql = "insert into FormacaoPosGraduacao(idFormacao_PG, idCurriculo_PG, instituicao_PG, periodo_PG, turno_PG, nome_PG, Tipo_PG, cidade_PG, uf_PG, inicio_PG, fim_PG)" +
                "values (@idFormacao_PG, @idCurriculo_PG, @instituicao_PG, @periodo_PG, @turno_PG, @nome_PG, @Tipo_PG, @cidade_PG, @uf_PG, @inicio_PG, @fim_PG)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }

        public void Alterar(PosGraduacaoViewModel formacao)
        {
            string sql = "update FormacaoPosGraduacao set instituicao_PG = @instituicao_PG, " + "periodo_PG = @periodo_PG, " + "turno_PG = @turno_PG, " + "nome_PG = @nome_PG, " + "Tipo_PG = @Tipo_PG, "
                + "cidade_PG = @cidade_PG, " + "uf_PG = @uf_PG, " + "inicio_PG = @inicio_PG, " + "fim_PG = @fim_PG where idFormacao_PG = @idFormacao_PG";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }


        private SqlParameter[] CriaParametros(PosGraduacaoViewModel formacao)
        {
            SqlParameter[] parametros = new SqlParameter[11];
            parametros[0] = new SqlParameter("idFormacao_PG", formacao.IdFormacao);
            parametros[1] = new SqlParameter("idCurriculo_PG", formacao.IdCurriculo);
            parametros[2] = new SqlParameter("instituicao_PG", formacao.Instituicao);
            parametros[3] = new SqlParameter("periodo_PG", formacao.Periodo);
            parametros[4] = new SqlParameter("turno_PG", formacao.Turno);
            parametros[5] = new SqlParameter("nome_PG", formacao.Curso);
            parametros[6] = new SqlParameter("Tipo_PG", formacao.Tipo);
            parametros[7] = new SqlParameter("cidade_PG", formacao.Cidade);
            parametros[8] = new SqlParameter("uf_PG", formacao.Uf);
            parametros[9] = new SqlParameter("inicio_PG", formacao.Inicio);
            parametros[10] = new SqlParameter("fim_PG", formacao.Conclusao);
            return parametros;
        }

        public void Excluir(int id)
        {
            string sql = "delete FormacaoPosGraduacao where idFormacao_PG =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(idFormacao_PG) +1, 1) as 'Maior' from FormacaoPosGraduacao";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}
