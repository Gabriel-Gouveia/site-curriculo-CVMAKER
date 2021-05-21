using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class IdiomaDAO
    {
        public void Inserir(IdiomaViewModel idioma)
        {
            string sql = "insert into Idiomas(Id_Idioma, Id_Curriculo, Idioma, Id_Nivel)" +
                "values (@Id_Idioma, @Id_Curriculo, @Idioma, @Id_Nivel)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        public void Alterar(IdiomaViewModel idioma)
        {
            string sql = "update Idiomas set Idioma = @Idioma, " + "Id_Nivel = @Id_Nivel where Id_Idioma = @Id_Idioma";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        private SqlParameter[] CriaParametros(IdiomaViewModel idioma)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("Id_Idioma", idioma.IdIdioma);
            parametros[1] = new SqlParameter("Id_Curriculo", idioma.IdCurriculo);
            parametros[2] = new SqlParameter("Idioma", idioma.Idioma);
            parametros[3] = new SqlParameter("Id_Nivel", idioma.IdNivel);
            return parametros;
        }

        public void Excluir(int id)
        {
            string sql = "delete Idiomas where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(Id_Idioma) +1, 1) as 'Maior' from Idiomas";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }

        public IdiomaViewModel[] Consulta(int id)
        {
            IdiomaViewModel[] i = new IdiomaViewModel[3];
            
            string sql = "select * from Idiomas where Id_Curriculo = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
            {

                for (int t = 0; t < i.Length; t++)
                {
                    i[t] = MontaIdioma(tabela.Rows[t]);
                }                
            }

            return i;
        }

        public IdiomaViewModel MontaIdioma(DataRow registro)
        {
            IdiomaViewModel i = new IdiomaViewModel();
            i.IdIdioma = Convert.ToInt32(registro["Id_Idioma"]);
            i.IdCurriculo = Convert.ToInt32(registro["Id_Curriculo"]);
            i.Idioma = registro["Idioma"].ToString();
            i.IdNivel = Convert.ToInt32(registro["Id_Nivel"]);
            return i;
        }

    }
}
