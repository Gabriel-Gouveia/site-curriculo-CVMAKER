using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models
{
    public class GraduacaoViewModel
    {
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Conclusao { get; set; }
        public int Periodo { get; set; }
        public string Cidade { get; set; }
        public string Tipo { get; set; }
        public string Turno { get; set; }
        public string Uf { get; set; }
        public int IdFormacao { get; set; }
        public int IdCurriculo { get; set; }
    }
}
