using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class EnderecoDAO
    {
        public void Inserir(EnderecoViewModel endereco)
        {
            string sql = "insert into Enderecos(idEnd, idCurriculo_end, estado, cidade, bairro, rua, cep)" + "values (@idEnd, @idCurriculo_end, @estado, @cidade, @bairro, @rua, @cep)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(endereco));
        }

        public void Alterar(EnderecoViewModel endereco)
        {
            string sql = "update Enderecos set estado = @estado, " + "cidade = @cidade, " + "bairro = @bairro," + "rua = @rua, " + "cep = @cep where idEnd = @idEnd";
            HelperDAO.ExecutaSQL(sql, CriaParametros(endereco));
        }
        private SqlParameter[] CriaParametros(EnderecoViewModel endereco)
        {
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("idEnd", endereco.Id);
            parametros[1] = new SqlParameter("idCurriculo_end", endereco.IdCurriculo);
            parametros[2] = new SqlParameter("estado", endereco.Estado);
            parametros[3] = new SqlParameter("cidade", endereco.Cidade);
            parametros[4] = new SqlParameter("bairro", endereco.Bairro);
            parametros[5] = new SqlParameter("rua", endereco.Rua);
            parametros[6] = new SqlParameter("cep", endereco.Cep);
            return parametros;
        }
        public void Excluir(int id)
        {
            string sql = "delete Enderecos where idEnd =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        // a consulta e listagem são feitas no CurriculoDAO. Lá já monta o endereço junto via inner join.

        public int ProximoId()
        {
            string instrucao = "select isnull(max(idEnd) +1, 1) as 'Maior' from Enderecos";
            DataTable table = HelperDAO.ExecutaSelect(instrucao, null);
            return Convert.ToInt32(table.Rows[0]["Maior"]);
        }
    }
}
