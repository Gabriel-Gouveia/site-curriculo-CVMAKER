using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CVMAKER_N2_.Models.DAO
{
    public class DadoDAO
    {
        public DadoViewModel Consulta(int id)
        {
            string sql = "select * from Curriculo inner join Enderecos on Curriculo.id = Enderecos.idCurriculo_end " +
                "inner join FormacaoGraduacao on Curriculo.id = FormacaoGraduacao.idCurriculo_G " +
                "inner join FormacaoPosGraduacao on Curriculo.id = FormacaoPosGraduacao.idCurriculo_PG " +
                "inner join FormacaoTecnico on Curriculo.id = FormacaoTecnico.idCurriculo_TEC " +
                "inner join Experiencias on Curriculo.id = Experiencias.id_curriculo_EXP where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaDado(tabela.Rows[0]);
        }
        public List<DadoViewModel> Listagem()
        {
            List<DadoViewModel> lista = new List<DadoViewModel>();
            string sql = "select * from Curriculo inner join Enderecos on Curriculo.id = Enderecos.idCurriculo_end " +
                "inner join FormacaoGraduacao on Curriculo.id = FormacaoGraduacao.idCurriculo_G " +
                "inner join FormacaoPosGraduacao on Curriculo.id = FormacaoPosGraduacao.idCurriculo_PG " +
                "inner join FormacaoTecnico on Curriculo.id = FormacaoTecnico.idCurriculo_TEC " +
                "inner join Experiencias on Curriculo.id = Experiencias.id_curriculo_EXP order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaDado(registro));
            return lista;
        }

        private DadoViewModel MontaDado(DataRow registro)
        {
            DadoViewModel d = new DadoViewModel();
            d.Curriculo = new CurriculoViewModel();
            d.Experiencia = new ExperienciaViewModel();
            d.Graduacao = new GraduacaoViewModel();
            d.PosGraduacao = new PosGraduacaoViewModel();
            d.Tecnico = new TecnicoViewModel();
            d.Endereco = new EnderecoViewModel();
            d.Idioma1 = new IdiomaViewModel();
            d.Idioma2 = new IdiomaViewModel();
            d.Idioma3 = new IdiomaViewModel();
            d.Curriculo.Id = Convert.ToInt32(registro["id"]);
            d.Curriculo.IdExperiencia = Convert.ToInt32(registro["idExperiencia"]);
            d.Curriculo.IdIdioma1 = Convert.ToInt32(registro["idIdioma1"]);
            d.Curriculo.IdIdioma2 = Convert.ToInt32(registro["idIdioma2"]);
            d.Curriculo.IdIdioma3 = Convert.ToInt32(registro["idIdioma3"]);
            d.Curriculo.IdFormacaoG = Convert.ToInt32(registro["idFormacaoG"]);
            d.Curriculo.IdFormacaoPG = Convert.ToInt32(registro["idFormacaoPG"]);
            d.Curriculo.IdFormacaoTec = Convert.ToInt32(registro["idFormacaoTec"]);
            d.Curriculo.Idade = Convert.ToInt32(registro["idade"]);
            d.Curriculo.Nome = registro["nome"].ToString();
            d.Curriculo.Cpf = registro["cpf"].ToString();
            d.Curriculo.CodEndereco = Convert.ToInt32(registro["codEndereco"]);
            d.Curriculo.Telefone = registro["telefone"].ToString();
            d.Curriculo.Email = registro["email"].ToString();
            d.Curriculo.Area = registro["area"].ToString();
            d.Curriculo.Cargo = registro["cargo"].ToString();
            d.Endereco.Id = Convert.ToInt32(registro["idEnd"]);
            d.Endereco.IdCurriculo = Convert.ToInt32(registro["idCurriculo_end"]);
            d.Endereco.Estado = registro["estado"].ToString();
            d.Endereco.Cidade = registro["cidade"].ToString();
            d.Endereco.Bairro = registro["bairro"].ToString();
            d.Endereco.Rua = registro["rua"].ToString();
            d.Endereco.Cep = registro["cep"].ToString();
            d.Graduacao.IdFormacao = Convert.ToInt32(registro["idFormacao_G"]);
            d.Graduacao.IdCurriculo = Convert.ToInt32(registro["idCurriculo_G"]);
            d.Graduacao.Instituicao = registro["instituicao_G"].ToString();
            d.Graduacao.Periodo = Convert.ToInt32(registro["periodo_G"]);
            d.Graduacao.Turno = registro["turno_G"].ToString();
            d.Graduacao.Curso = registro["nome_G"].ToString();
            d.Graduacao.Tipo = registro["Tipo_G"].ToString();
            d.Graduacao.Cidade = registro["cidade_G"].ToString();
            d.Graduacao.Uf = registro["uf_G"].ToString();
            d.Graduacao.Inicio = Convert.ToDateTime(registro["inicio_G"]);
            d.Graduacao.Conclusao = Convert.ToDateTime(registro["fim_G"]);
            d.PosGraduacao.IdFormacao = Convert.ToInt32(registro["idFormacao_PG"]);
            d.PosGraduacao.IdCurriculo = Convert.ToInt32(registro["idCurriculo_PG"]);
            d.PosGraduacao.Instituicao = registro["instituicao_PG"].ToString();
            d.PosGraduacao.Periodo = Convert.ToInt32(registro["periodo_PG"]);
            d.PosGraduacao.Turno = registro["turno_PG"].ToString();
            d.PosGraduacao.Curso = registro["nome_PG"].ToString();
            d.PosGraduacao.Tipo = registro["Tipo_PG"].ToString();
            d.PosGraduacao.Cidade = registro["cidade_PG"].ToString();
            d.PosGraduacao.Uf = registro["uf_PG"].ToString();
            d.PosGraduacao.Inicio = Convert.ToDateTime(registro["inicio_PG"]);
            d.PosGraduacao.Conclusao = Convert.ToDateTime(registro["fim_PG"]);
            d.Tecnico.IdFormacao = Convert.ToInt32(registro["idFormacao_TEC"]);
            d.Tecnico.IdCurriculo = Convert.ToInt32(registro["idCurriculo_TEC"]);
            d.Tecnico.Instituicao = registro["instituicao_TEC"].ToString();
            d.Tecnico.Periodo = Convert.ToInt32(registro["periodo_TEC"]);
            d.Tecnico.Turno = registro["turno_TEC"].ToString();
            d.Tecnico.Curso = registro["nome_TEC"].ToString();
            d.Tecnico.Cidade = registro["cidade_TEC"].ToString();
            d.Tecnico.Uf = registro["uf_TEC"].ToString();
            d.Tecnico.Inicio = Convert.ToDateTime(registro["inicio_TEC"]);
            d.Tecnico.Conclusao = Convert.ToDateTime(registro["fim_TEC"]);
            d.Experiencia.Id = Convert.ToInt32(registro["id_experiencia"]);
            d.Experiencia.IdCurriculo = Convert.ToInt32(registro["id_curriculo_EXP"]);
            d.Experiencia.NomeDaEmpresa = registro["nome_empresa"].ToString();
            d.Experiencia.Inicio = Convert.ToDateTime(registro["inicio_EXP"]);
            d.Experiencia.Fim = Convert.ToDateTime(registro["fim_EXP"]);
            d.Experiencia.Cargo = registro["cargo_EXP"].ToString();
            IdiomaDAO idiomaDAO = new IdiomaDAO();
            IdiomaViewModel[] vetor;
            vetor = idiomaDAO.Consulta(d.Curriculo.Id);
            d.Idioma1 = vetor[0];
            d.Idioma2 = vetor[1];
            d.Idioma3 = vetor[2];
            return d;
        }
    }
}
