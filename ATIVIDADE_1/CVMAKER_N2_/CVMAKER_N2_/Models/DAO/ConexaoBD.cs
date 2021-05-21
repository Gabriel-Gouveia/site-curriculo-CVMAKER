using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            // minha máquina possui o SQLEXPRESS, alterei para SQL_2019 para seu teste:
            string conexao = "Data source=LOCALHOST\\SQL_2019; Database=DBCvMaker; integrated security = true"; // funcionou na minha máquina (SQLEXPRESS).
            // se não conseguir conectar na primeira vez, tente se conectar pela segunda vez!
            SqlConnection cx = new SqlConnection(conexao);
            cx.Open();
            return cx;
        }
    }
}
