using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class TurnoDAO
    {
        public List<TurnoViewModel> ListaTurnos()
        {
            List<TurnoViewModel> lista = new List<TurnoViewModel>();
            DataTable tabela = HelperDAO.ExecutaSelect("select * from Turnos order by Id", null);
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(MontaTurno(registro));
            }
            return lista;
        }

        public TurnoViewModel MontaTurno(DataRow registro)
        {
            TurnoViewModel turno = new TurnoViewModel()
            {
                Id = Convert.ToInt32(registro["Id"]),
                Texto = registro["Texto"].ToString()

            };
            return turno;
        }
    }
}
