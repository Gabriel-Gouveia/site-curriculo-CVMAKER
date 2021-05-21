using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class TipoPosDAO
    {
        public List<TipoPosViewModel> ListaPos()
        {
            List<TipoPosViewModel> lista = new List<TipoPosViewModel>();
            DataTable tabela = HelperDAO.ExecutaSelect("select * from tipoFormacaoPG order by descricao", null);
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaPos(registro));
            }
            return lista;
        }

        public TipoPosViewModel MontaPos(DataRow registro)
        {
            TipoPosViewModel pos = new TipoPosViewModel()
            {
                Id = Convert.ToInt32(registro["idTipo"]),
                Descricao = registro["descricao"].ToString()

            };
            return pos;
        }
    }
}
