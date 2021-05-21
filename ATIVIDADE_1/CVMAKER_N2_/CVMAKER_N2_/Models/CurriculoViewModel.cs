using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models
{
    public class CurriculoViewModel
    {
        // Formação acadêmica
        //public Tecnico tecnico = new Tecnico();
        //public Faculdade faculdade = new Faculdade();
        //public PosGraduacao pos = new PosGraduacao();

        // Outros cursos/habilidades 
        //public string Cursos { get; set; }

        // Idiomas
        //public Idioma[] idiomas = new Idioma[5];

        // Dados pessoais
        public int Id { get; set; }
        public int CodEndereco { get; set; }
        public int IdExperiencia { get; set; }
        public int IdIdioma1 { get; set; }
        public int IdIdioma2 { get; set; }
        public int IdIdioma3 { get; set; }
        public int IdFormacaoG { get; set; }
        public int IdFormacaoPG { get; set; }
        public int IdFormacaoTec { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }

        // Experiência

        //public Experiencia[] experiencia = new Experiencia[3];
    }
}
