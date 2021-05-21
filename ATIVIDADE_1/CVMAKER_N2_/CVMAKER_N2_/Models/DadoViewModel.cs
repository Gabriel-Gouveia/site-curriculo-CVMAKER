using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models
{
    public class DadoViewModel
    {
        public CurriculoViewModel Curriculo { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public ExperienciaViewModel Experiencia { get; set; }
        public GraduacaoViewModel Graduacao { get; set; }
        public PosGraduacaoViewModel PosGraduacao { get; set; }
        public TecnicoViewModel Tecnico { get; set; }
        public IdiomaViewModel Idioma1 { get; set; }
        public IdiomaViewModel Idioma2 { get; set; }
        public IdiomaViewModel Idioma3 { get; set; }
    }
}
