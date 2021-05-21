using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models
{
    public class ExperienciaViewModel
    {
        public int Id { get; set; }
        public int IdCurriculo { get; set; }
        public string NomeDaEmpresa { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Cargo { get; set; }
    }
}
