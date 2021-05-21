using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class ExperienciaDAO
    {
        public void Inserir(ExperienciaViewModel experiencia)
        {
            string sql = "insert into Experiencias(id_experiencia, id_curriculo_EXP, nome_empresa, inicio_EXP, fim_EXP, cargo_EXP)" +
                "values (@id_experiencia, @id_curriculo_EXP, @nome_empresa, @inicio_EXP, @fim_EXP, @cargo_EXP)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(experiencia));
        }

        public void Alterar(ExperienciaViewModel experiencia)
        {
            string sql = "update Experiencias set nome_empresa = @nome_empresa, " + "inicio_EXP = @inicio_EXP, " + "fim_EXP = @fim_EXP, "
                + "cargo_EXP = @cargo_EXP where id_experiencia = @id_experiencia";
            HelperDAO.ExecutaSQL(sql, CriaParametros(experiencia));
        }

        private SqlParameter[] CriaParametros(ExperienciaViewModel experiencia)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("id_experiencia", experiencia.Id);
            parametros[1] = new SqlParameter("id_curriculo_EXP", experiencia.IdCurriculo);
            parametros[2] = new SqlParameter("nome_empresa", experiencia.NomeDaEmpresa);
            parametros[3] = new SqlParameter("inicio_EXP", experiencia.Inicio);
            parametros[4] = new SqlParameter("fim_EXP", experiencia.Fim);
            parametros[5] = new SqlParameter("cargo_EXP", experiencia.Cargo);
            return parametros;
        }

        public void Excluir(int id)
        {
            string sql = "delete Experiencias where id_experiencia =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(id_experiencia) +1, 1) as 'Maior' from Experiencias";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}
