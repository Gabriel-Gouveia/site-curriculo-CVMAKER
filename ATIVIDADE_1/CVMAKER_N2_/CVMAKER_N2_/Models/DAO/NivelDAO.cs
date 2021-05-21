using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class NivelDAO
    {
        public List<NivelViewModel> ListaNiveis()
        {
            List<NivelViewModel> lista = new List<NivelViewModel>();
            DataTable tabela = HelperDAO.ExecutaSelect("select * from Nivel order by Id_Nivel", null);
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaNivel(registro));
            }
            return lista;
        }

        public NivelViewModel MontaNivel(DataRow registro)
        {
            NivelViewModel level = new NivelViewModel()
            {
                IdNivel = Convert.ToInt32(registro["Id_Nivel"]),
                Descricao = registro["Descricao"].ToString()

            };
            return level;
        }
    }
}
