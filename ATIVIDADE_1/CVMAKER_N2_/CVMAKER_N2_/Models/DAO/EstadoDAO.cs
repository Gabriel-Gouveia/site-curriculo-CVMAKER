using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class EstadoDAO
    {
        public List<EstadoViewModel> ListaEstados()
        {
            List<EstadoViewModel> lista = new List<EstadoViewModel>();
            DataTable tabela = HelperDAO.ExecutaSelect("select * from Estados order by nome", null);
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaEstado(registro));
            }
            return lista;
        }

        public EstadoViewModel MontaEstado(DataRow registro)
        {
            EstadoViewModel uf = new EstadoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString()

            };
            return uf;
        }
    }
}
