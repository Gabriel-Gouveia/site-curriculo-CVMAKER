using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class TecnicoDAO
    {
        public void Inserir(TecnicoViewModel formacao)
        {
            string sql = "insert into FormacaoTecnico(idFormacao_TEC, idCurriculo_TEC, instituicao_TEC, periodo_TEC, turno_TEC, nome_TEC, cidade_TEC, uf_TEC, inicio_TEC, fim_TEC)" +
                "values (@idFormacao_TEC, @idCurriculo_TEC, @instituicao_TEC, @periodo_TEC, @turno_TEC, @nome_TEC, @cidade_TEC, @uf_TEC, @inicio_TEC, @fim_TEC)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }

        public void Alterar(TecnicoViewModel formacao)
        {
            string sql = "update FormacaoTecnico set instituicao_TEC = @instituicao_TEC, " + " periodo_TEC = @periodo_TEC, " + " turno_TEC = @turno_TEC, " + " nome_TEC = @nome_TEC, "
                + " cidade_TEC = @cidade_TEC, " + " uf_TEC = @uf_TEC, " + " inicio_TEC = @inicio_TEC, " + " fim_TEC = @fim_TEC where idFormacao_TEC = @idFormacao_TEC";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }


        private SqlParameter[] CriaParametros(TecnicoViewModel formacao)
        {
            SqlParameter[] parametros = new SqlParameter[10];
            parametros[0] = new SqlParameter("idFormacao_TEC", formacao.IdFormacao);
            parametros[1] = new SqlParameter("idCurriculo_TEC", formacao.IdCurriculo);
            parametros[2] = new SqlParameter("instituicao_TEC", formacao.Instituicao);
            parametros[3] = new SqlParameter("periodo_TEC", formacao.Periodo);
            parametros[4] = new SqlParameter("turno_TEC", formacao.Turno);
            parametros[5] = new SqlParameter("nome_TEC", formacao.Curso);
            parametros[6] = new SqlParameter("cidade_TEC", formacao.Cidade);
            parametros[7] = new SqlParameter("uf_TEC", formacao.Uf);
            parametros[8] = new SqlParameter("inicio_TEC", formacao.Inicio);
            parametros[9] = new SqlParameter("fim_TEC", formacao.Conclusao);
            return parametros;
        }

        public void Excluir(int id)
        {
            string sql = "delete FormacaoTecnico where idFormacao_TEC =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(idFormacao_TEC) +1, 1) as 'Maior' from FormacaoTecnico";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}
