using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class TipoGraduacaoDAO
    {
        public List<TipoGraduacaoViewModel> ListaGraduacoes()
        {
            List<TipoGraduacaoViewModel> lista = new List<TipoGraduacaoViewModel>();
            DataTable tabela = HelperDAO.ExecutaSelect("select * from tipoFormacaoG order by descricao", null);
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaGraduacao(registro));
            }
            return lista;
        }

        public TipoGraduacaoViewModel MontaGraduacao(DataRow registro)
        {
            TipoGraduacaoViewModel grad = new TipoGraduacaoViewModel()
            {
                Id = Convert.ToInt32(registro["idTipo"]),
                Descricao = registro["descricao"].ToString()

            };
            return grad;
        }
    }
}
