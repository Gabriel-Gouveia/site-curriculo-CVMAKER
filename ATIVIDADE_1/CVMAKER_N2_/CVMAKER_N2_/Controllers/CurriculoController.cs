
using CVMAKER_N2_.Models;
using CVMAKER_N2_.Models.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVMaker_N2.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Cadastro()
        {
            DadoViewModel ce = new DadoViewModel();
            CurriculoDAO cdao = new CurriculoDAO();
            EnderecoDAO edao = new EnderecoDAO();
            ce.Curriculo = new CurriculoViewModel();
            ce.Endereco = new EnderecoViewModel();
            ce.Experiencia = new ExperienciaViewModel();
            ce.Graduacao = new GraduacaoViewModel();
            ce.PosGraduacao = new PosGraduacaoViewModel();
            ce.Tecnico = new TecnicoViewModel();
            ce.Idioma1 = new IdiomaViewModel();
            ce.Idioma2 = new IdiomaViewModel();
            ce.Idioma3 = new IdiomaViewModel();
            ViewBag.Operacao = "I";
            PreparaListaEstadosParaCombo();
            PreparaListaGraduacoesParaCombo();
            PreparaListaPosGraduacoesParaCombo();
            PreparaListaTurnosParaCombo();
            PreparaListaNiveisParaCombo();
            return View("Cadastro", ce);
        }         

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Listar()
        {
            try
            {
                DadoDAO dao = new DadoDAO();
                List<DadoViewModel> lista = dao.Listagem();

                foreach (DadoViewModel dado in lista)
                {
                    switch (dado.PosGraduacao.Uf)
                    {
                        case "1":
                            dado.PosGraduacao.Uf = "SP";
                            break;

                        case "2":
                            dado.PosGraduacao.Uf = "RJ";
                            break;

                        case "3":
                            dado.PosGraduacao.Uf = "MG";
                            break;

                        case "4":
                            dado.PosGraduacao.Uf = "ES";
                            break;

                        case "5":
                            dado.PosGraduacao.Uf = "PR";
                            break;

                        case "6":
                            dado.PosGraduacao.Uf = "SC";
                            break;

                        case "7":
                            dado.PosGraduacao.Uf = "RS";
                            break;

                        case "8":
                            dado.PosGraduacao.Uf = "AM";
                            break;

                        case "9":
                            dado.PosGraduacao.Uf = "AP";
                            break;

                        case "10":
                            dado.PosGraduacao.Uf = "AC";
                            break;

                        case "11":
                            dado.PosGraduacao.Uf = "RO";
                            break;

                        case "12":
                            dado.PosGraduacao.Uf = "RR";
                            break;

                        case "13":
                            dado.PosGraduacao.Uf = "TO";
                            break;

                        case "14":
                            dado.PosGraduacao.Uf = "MA";
                            break;

                        case "15":
                            dado.PosGraduacao.Uf = "PI";
                            break;

                        case "16":
                            dado.PosGraduacao.Uf = "CE";
                            break;

                        case "17":
                            dado.PosGraduacao.Uf = "AL";
                            break;

                        case "18":
                            dado.PosGraduacao.Uf = "RN";
                            break;

                        case "19":
                            dado.PosGraduacao.Uf = "PE";
                            break;

                        case "20":
                            dado.PosGraduacao.Uf = "PB";
                            break;

                        case "21":
                            dado.PosGraduacao.Uf = "PA";
                            break;

                        case "22":
                            dado.PosGraduacao.Uf = "SE";
                            break;

                        case "23":
                            dado.PosGraduacao.Uf = "BA";
                            break;

                        case "24":
                            dado.PosGraduacao.Uf = "MT";
                            break;

                        case "25":
                            dado.PosGraduacao.Uf = "MS";
                            break;

                        case "26":
                            dado.PosGraduacao.Uf = "GO";
                            break;

                        case "27":
                            dado.PosGraduacao.Uf = "DF";
                            break;
                    }

                    switch (dado.Graduacao.Uf)
                    {
                        case "1":
                            dado.Graduacao.Uf = "SP";
                            break;

                        case "2":
                            dado.Graduacao.Uf = "RJ";
                            break;

                        case "3":
                            dado.Graduacao.Uf = "MG";
                            break;

                        case "4":
                            dado.Graduacao.Uf = "ES";
                            break;

                        case "5":
                            dado.Graduacao.Uf = "PR";
                            break;

                        case "6":
                            dado.Graduacao.Uf = "SC";
                            break;

                        case "7":
                            dado.Graduacao.Uf = "RS";
                            break;

                        case "8":
                            dado.Graduacao.Uf = "AM";
                            break;

                        case "9":
                            dado.Graduacao.Uf = "AP";
                            break;

                        case "10":
                            dado.Graduacao.Uf = "AC";
                            break;

                        case "11":
                            dado.Graduacao.Uf = "RO";
                            break;

                        case "12":
                            dado.Graduacao.Uf = "RR";
                            break;

                        case "13":
                            dado.Graduacao.Uf = "TO";
                            break;

                        case "14":
                            dado.Graduacao.Uf = "MA";
                            break;

                        case "15":
                            dado.Graduacao.Uf = "PI";
                            break;

                        case "16":
                            dado.Graduacao.Uf = "CE";
                            break;

                        case "17":
                            dado.Graduacao.Uf = "AL";
                            break;

                        case "18":
                            dado.Graduacao.Uf = "RN";
                            break;

                        case "19":
                            dado.Graduacao.Uf = "PE";
                            break;

                        case "20":
                            dado.Graduacao.Uf = "PB";
                            break;

                        case "21":
                            dado.Graduacao.Uf = "PA";
                            break;

                        case "22":
                            dado.Graduacao.Uf = "SE";
                            break;

                        case "23":
                            dado.Graduacao.Uf = "BA";
                            break;

                        case "24":
                            dado.Graduacao.Uf = "MT";
                            break;

                        case "25":
                            dado.Graduacao.Uf = "MS";
                            break;

                        case "26":
                            dado.Graduacao.Uf = "GO";
                            break;

                        case "27":
                            dado.Graduacao.Uf = "DF";
                            break;
                    }

                    switch (dado.Endereco.Estado)
                    {
                        case "1":
                            dado.Endereco.Estado = "SP";
                            break;

                        case "2":
                            dado.Endereco.Estado = "RJ";
                            break;

                        case "3":
                            dado.Endereco.Estado = "MG";
                            break;

                        case "4":
                            dado.Endereco.Estado = "ES";
                            break;

                        case "5":
                            dado.Endereco.Estado = "PR";
                            break;

                        case "6":
                            dado.Endereco.Estado = "SC";
                            break;

                        case "7":
                            dado.Endereco.Estado = "RS";
                            break;

                        case "8":
                            dado.Endereco.Estado = "AM";
                            break;

                        case "9":
                            dado.Endereco.Estado = "AP";
                            break;

                        case "10":
                            dado.Endereco.Estado = "AC";
                            break;

                        case "11":
                            dado.Endereco.Estado = "RO";
                            break;

                        case "12":
                            dado.Endereco.Estado = "RR";
                            break;

                        case "13":
                            dado.Endereco.Estado = "TO";
                            break;

                        case "14":
                            dado.Endereco.Estado = "MA";
                            break;

                        case "15":
                            dado.Endereco.Estado = "PI";
                            break;

                        case "16":
                            dado.Endereco.Estado = "CE";
                            break;

                        case "17":
                            dado.Endereco.Estado = "AL";
                            break;

                        case "18":
                            dado.Endereco.Estado = "RN";
                            break;

                        case "19":
                            dado.Endereco.Estado = "PE";
                            break;

                        case "20":
                            dado.Endereco.Estado = "PB";
                            break;

                        case "21":
                            dado.Endereco.Estado = "PA";
                            break;

                        case "22":
                            dado.Endereco.Estado = "SE";
                            break;

                        case "23":
                            dado.Endereco.Estado = "BA";
                            break;

                        case "24":
                            dado.Endereco.Estado = "MT";
                            break;

                        case "25":
                            dado.Endereco.Estado = "MS";
                            break;

                        case "26":
                            dado.Endereco.Estado = "GO";
                            break;

                        case "27":
                            dado.Endereco.Estado = "DF";
                            break;
                    }

                    if (dado.Graduacao.Tipo != null)
                    {
                        switch (dado.Graduacao.Tipo)
                        {
                            case "1":
                                dado.Graduacao.Tipo = "Bacharel";
                                break;

                            case "2":
                                dado.Graduacao.Tipo = "Tecnólogo";
                                break;

                            case "3":
                                dado.Graduacao.Tipo = "Licenciatura";
                                break;
                        }
                    }


                    if (dado.PosGraduacao.Tipo != null)
                    {
                        switch (dado.PosGraduacao.Tipo)
                        {
                            case "1":
                                dado.PosGraduacao.Tipo = "Mestre";
                                break;

                            case "2":
                                dado.PosGraduacao.Tipo = "Doutor";
                                break;

                            case "3":
                                dado.PosGraduacao.Tipo = "Especialista";
                                break;

                            case "4":
                                dado.PosGraduacao.Tipo = "MBA";
                                break;
                        }
                    }

                    if (dado.Graduacao.Turno != null)
                    {
                        switch (dado.Graduacao.Turno)
                        {
                            case "1":
                                dado.Graduacao.Turno = "Manhã";
                                break;

                            case "2":
                                dado.Graduacao.Turno = "Tarde";
                                break;

                            case "3":
                                dado.Graduacao.Turno = "Noite";
                                break;

                            case "4":
                                dado.Graduacao.Turno = "Integral";
                                break;
                        }
                    }

                    if (dado.PosGraduacao.Turno != null)
                    {
                        switch (dado.PosGraduacao.Turno)
                        {
                            case "1":
                                dado.PosGraduacao.Turno = "Manhã";
                                break;

                            case "2":
                                dado.PosGraduacao.Turno = "Tarde";
                                break;

                            case "3":
                                dado.PosGraduacao.Turno = "Noite";
                                break;

                            case "4":
                                dado.PosGraduacao.Turno = "Integral";
                                break;
                        }
                    }

                    if (dado.Tecnico.Turno != null)
                    {
                        switch (dado.Tecnico.Turno)
                        {
                            case "1":
                                dado.Tecnico.Turno = "Manhã";
                                break;

                            case "2":
                                dado.Tecnico.Turno = "Tarde";
                                break;

                            case "3":
                                dado.Tecnico.Turno = "Noite";
                                break;

                            case "4":
                                dado.Tecnico.Turno = "Integral";
                                break;
                        }
                    }

                    switch (dado.Tecnico.Uf)
                    {
                        case "1":
                            dado.Tecnico.Uf = "SP";
                            break;

                        case "2":
                            dado.Tecnico.Uf = "RJ";
                            break;

                        case "3":
                            dado.Tecnico.Uf = "MG";
                            break;

                        case "4":
                            dado.Tecnico.Uf = "ES";
                            break;

                        case "5":
                            dado.Tecnico.Uf = "PR";
                            break;

                        case "6":
                            dado.Tecnico.Uf = "SC";
                            break;

                        case "7":
                            dado.Tecnico.Uf = "RS";
                            break;

                        case "8":
                            dado.Tecnico.Uf = "AM";
                            break;

                        case "9":
                            dado.Tecnico.Uf = "AP";
                            break;

                        case "10":
                            dado.Tecnico.Uf = "AC";
                            break;

                        case "11":
                            dado.Tecnico.Uf = "RO";
                            break;

                        case "12":
                            dado.Tecnico.Uf = "RR";
                            break;

                        case "13":
                            dado.Tecnico.Uf = "TO";
                            break;

                        case "14":
                            dado.Tecnico.Uf = "MA";
                            break;

                        case "15":
                            dado.Tecnico.Uf = "PI";
                            break;

                        case "16":
                            dado.Tecnico.Uf = "CE";
                            break;

                        case "17":
                            dado.Tecnico.Uf = "AL";
                            break;

                        case "18":
                            dado.Tecnico.Uf = "RN";
                            break;

                        case "19":
                            dado.Tecnico.Uf = "PE";
                            break;

                        case "20":
                            dado.Tecnico.Uf = "PB";
                            break;

                        case "21":
                            dado.Tecnico.Uf = "PA";
                            break;

                        case "22":
                            dado.Tecnico.Uf = "SE";
                            break;

                        case "23":
                            dado.Tecnico.Uf = "BA";
                            break;

                        case "24":
                            dado.Tecnico.Uf = "MT";
                            break;

                        case "25":
                            dado.Tecnico.Uf = "MS";
                            break;

                        case "26":
                            dado.Tecnico.Uf = "GO";
                            break;

                        case "27":
                            dado.Tecnico.Uf = "DF";
                            break;
                    }
                }
                return View("Listagem", lista);
            }

            catch (Exception erro)
            {
                return View("error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Deletar(int id)
        {
            try
            {
                CurriculoDAO dao = new CurriculoDAO();
                dao.Excluir(id);
                return RedirectToAction("Listar");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }        

        public IActionResult Busca()
        {
            ModelState.Clear();
            IdPesquisaViewModel id = new IdPesquisaViewModel();
            return View("Busca", id);
        }

        public IActionResult RetornaCurriculo(IdPesquisaViewModel idpesquisa)
        {
            DadoDAO dao = new DadoDAO();
            DadoViewModel dado = dao.Consulta(idpesquisa.Id);
            if (dado == null)
            {
                ModelState.AddModelError("Id", "O currículo não foi encontrado com essa id.");
                if (ModelState.IsValid == false)
                    return View("Busca", idpesquisa);
            }

            switch (dado.PosGraduacao.Uf)
            {
                case "1":
                    dado.PosGraduacao.Uf = "SP";
                    break;

                case "2":
                    dado.PosGraduacao.Uf = "RJ";
                    break;

                case "3":
                    dado.PosGraduacao.Uf = "MG";
                    break;

                case "4":
                    dado.PosGraduacao.Uf = "ES";
                    break;

                case "5":
                    dado.PosGraduacao.Uf = "PR";
                    break;

                case "6":
                    dado.PosGraduacao.Uf = "SC";
                    break;

                case "7":
                    dado.PosGraduacao.Uf = "RS";
                    break;

                case "8":
                    dado.PosGraduacao.Uf = "AM";
                    break;

                case "9":
                    dado.PosGraduacao.Uf = "AP";
                    break;

                case "10":
                    dado.PosGraduacao.Uf = "AC";
                    break;

                case "11":
                    dado.PosGraduacao.Uf = "RO";
                    break;

                case "12":
                    dado.PosGraduacao.Uf = "RR";
                    break;

                case "13":
                    dado.PosGraduacao.Uf = "TO";
                    break;

                case "14":
                    dado.PosGraduacao.Uf = "MA";
                    break;

                case "15":
                    dado.PosGraduacao.Uf = "PI";
                    break;

                case "16":
                    dado.PosGraduacao.Uf = "CE";
                    break;

                case "17":
                    dado.PosGraduacao.Uf = "AL";
                    break;

                case "18":
                    dado.PosGraduacao.Uf = "RN";
                    break;

                case "19":
                    dado.PosGraduacao.Uf = "PE";
                    break;

                case "20":
                    dado.PosGraduacao.Uf = "PB";
                    break;

                case "21":
                    dado.PosGraduacao.Uf = "PA";
                    break;

                case "22":
                    dado.PosGraduacao.Uf = "SE";
                    break;

                case "23":
                    dado.PosGraduacao.Uf = "BA";
                    break;

                case "24":
                    dado.PosGraduacao.Uf = "MT";
                    break;

                case "25":
                    dado.PosGraduacao.Uf = "MS";
                    break;

                case "26":
                    dado.PosGraduacao.Uf = "GO";
                    break;

                case "27":
                    dado.PosGraduacao.Uf = "DF";
                    break;
            }

            switch (dado.Graduacao.Uf)
            {
                case "1":
                    dado.Graduacao.Uf = "SP";
                    break;

                case "2":
                    dado.Graduacao.Uf = "RJ";
                    break;

                case "3":
                    dado.Graduacao.Uf = "MG";
                    break;

                case "4":
                    dado.Graduacao.Uf = "ES";
                    break;

                case "5":
                    dado.Graduacao.Uf = "PR";
                    break;

                case "6":
                    dado.Graduacao.Uf = "SC";
                    break;

                case "7":
                    dado.Graduacao.Uf = "RS";
                    break;

                case "8":
                    dado.Graduacao.Uf = "AM";
                    break;

                case "9":
                    dado.Graduacao.Uf = "AP";
                    break;

                case "10":
                    dado.Graduacao.Uf = "AC";
                    break;

                case "11":
                    dado.Graduacao.Uf = "RO";
                    break;

                case "12":
                    dado.Graduacao.Uf = "RR";
                    break;

                case "13":
                    dado.Graduacao.Uf = "TO";
                    break;

                case "14":
                    dado.Graduacao.Uf = "MA";
                    break;

                case "15":
                    dado.Graduacao.Uf = "PI";
                    break;

                case "16":
                    dado.Graduacao.Uf = "CE";
                    break;

                case "17":
                    dado.Graduacao.Uf = "AL";
                    break;

                case "18":
                    dado.Graduacao.Uf = "RN";
                    break;

                case "19":
                    dado.Graduacao.Uf = "PE";
                    break;

                case "20":
                    dado.Graduacao.Uf = "PB";
                    break;

                case "21":
                    dado.Graduacao.Uf = "PA";
                    break;

                case "22":
                    dado.Graduacao.Uf = "SE";
                    break;

                case "23":
                    dado.Graduacao.Uf = "BA";
                    break;

                case "24":
                    dado.Graduacao.Uf = "MT";
                    break;

                case "25":
                    dado.Graduacao.Uf = "MS";
                    break;

                case "26":
                    dado.Graduacao.Uf = "GO";
                    break;

                case "27":
                    dado.Graduacao.Uf = "DF";
                    break;
            }

            switch (dado.Endereco.Estado)
            {
                case "1":
                    dado.Endereco.Estado = "SP";
                    break;

                case "2":
                    dado.Endereco.Estado = "RJ";
                    break;

                case "3":
                    dado.Endereco.Estado = "MG";
                    break;

                case "4":
                    dado.Endereco.Estado = "ES";
                    break;

                case "5":
                    dado.Endereco.Estado = "PR";
                    break;

                case "6":
                    dado.Endereco.Estado = "SC";
                    break;

                case "7":
                    dado.Endereco.Estado = "RS";
                    break;

                case "8":
                    dado.Endereco.Estado = "AM";
                    break;

                case "9":
                    dado.Endereco.Estado = "AP";
                    break;

                case "10":
                    dado.Endereco.Estado = "AC";
                    break;

                case "11":
                    dado.Endereco.Estado = "RO";
                    break;

                case "12":
                    dado.Endereco.Estado = "RR";
                    break;

                case "13":
                    dado.Endereco.Estado = "TO";
                    break;

                case "14":
                    dado.Endereco.Estado = "MA";
                    break;

                case "15":
                    dado.Endereco.Estado = "PI";
                    break;

                case "16":
                    dado.Endereco.Estado = "CE";
                    break;

                case "17":
                    dado.Endereco.Estado = "AL";
                    break;

                case "18":
                    dado.Endereco.Estado = "RN";
                    break;

                case "19":
                    dado.Endereco.Estado = "PE";
                    break;

                case "20":
                    dado.Endereco.Estado = "PB";
                    break;

                case "21":
                    dado.Endereco.Estado = "PA";
                    break;

                case "22":
                    dado.Endereco.Estado = "SE";
                    break;

                case "23":
                    dado.Endereco.Estado = "BA";
                    break;

                case "24":
                    dado.Endereco.Estado = "MT";
                    break;

                case "25":
                    dado.Endereco.Estado = "MS";
                    break;

                case "26":
                    dado.Endereco.Estado = "GO";
                    break;

                case "27":
                    dado.Endereco.Estado = "DF";
                    break;
            }

            if (dado.Graduacao.Tipo != null)
            {
                switch (dado.Graduacao.Tipo)
                {
                    case "1":
                        dado.Graduacao.Tipo = "Bacharel";
                        break;

                    case "2":
                        dado.Graduacao.Tipo = "Tecnólogo";
                        break;

                    case "3":
                        dado.Graduacao.Tipo = "Licenciatura";
                        break;
                }
            }


            if (dado.PosGraduacao.Tipo != null)
            {
                switch (dado.PosGraduacao.Tipo)
                {
                    case "1":
                        dado.PosGraduacao.Tipo = "Mestre";
                        break;

                    case "2":
                        dado.PosGraduacao.Tipo = "Doutor";
                        break;

                    case "3":
                        dado.PosGraduacao.Tipo = "Especialista";
                        break;

                    case "4":
                        dado.PosGraduacao.Tipo = "MBA";
                        break;
                }
            }

            if (dado.Graduacao.Turno != null)
            {
                switch (dado.Graduacao.Turno)
                {
                    case "1":
                        dado.Graduacao.Turno = "Manhã";
                        break;

                    case "2":
                        dado.Graduacao.Turno = "Tarde";
                        break;

                    case "3":
                        dado.Graduacao.Turno = "Noite";
                        break;

                    case "4":
                        dado.Graduacao.Turno = "Integral";
                        break;
                }
            }

            if (dado.PosGraduacao.Turno != null)
            {
                switch (dado.PosGraduacao.Turno)
                {
                    case "1":
                        dado.PosGraduacao.Turno = "Manhã";
                        break;

                    case "2":
                        dado.PosGraduacao.Turno = "Tarde";
                        break;

                    case "3":
                        dado.PosGraduacao.Turno = "Noite";
                        break;

                    case "4":
                        dado.PosGraduacao.Turno = "Integral";
                        break;
                }
            }

            if (dado.Tecnico.Turno != null)
            {
                switch (dado.Tecnico.Turno)
                {
                    case "1":
                        dado.Tecnico.Turno = "Manhã";
                        break;

                    case "2":
                        dado.Tecnico.Turno = "Tarde";
                        break;

                    case "3":
                        dado.Tecnico.Turno = "Noite";
                        break;

                    case "4":
                        dado.Tecnico.Turno = "Integral";
                        break;
                }
            }

            switch (dado.Tecnico.Uf)
            {
                case "1":
                    dado.Tecnico.Uf = "SP";
                    break;

                case "2":
                    dado.Tecnico.Uf = "RJ";
                    break;

                case "3":
                    dado.Tecnico.Uf = "MG";
                    break;

                case "4":
                    dado.Tecnico.Uf = "ES";
                    break;

                case "5":
                    dado.Tecnico.Uf = "PR";
                    break;

                case "6":
                    dado.Tecnico.Uf = "SC";
                    break;

                case "7":
                    dado.Tecnico.Uf = "RS";
                    break;

                case "8":
                    dado.Tecnico.Uf = "AM";
                    break;

                case "9":
                    dado.Tecnico.Uf = "AP";
                    break;

                case "10":
                    dado.Tecnico.Uf = "AC";
                    break;

                case "11":
                    dado.Tecnico.Uf = "RO";
                    break;

                case "12":
                    dado.Tecnico.Uf = "RR";
                    break;

                case "13":
                    dado.Tecnico.Uf = "TO";
                    break;

                case "14":
                    dado.Tecnico.Uf = "MA";
                    break;

                case "15":
                    dado.Tecnico.Uf = "PI";
                    break;

                case "16":
                    dado.Tecnico.Uf = "CE";
                    break;

                case "17":
                    dado.Tecnico.Uf = "AL";
                    break;

                case "18":
                    dado.Tecnico.Uf = "RN";
                    break;

                case "19":
                    dado.Tecnico.Uf = "PE";
                    break;

                case "20":
                    dado.Tecnico.Uf = "PB";
                    break;

                case "21":
                    dado.Tecnico.Uf = "PA";
                    break;

                case "22":
                    dado.Tecnico.Uf = "SE";
                    break;

                case "23":
                    dado.Tecnico.Uf = "BA";
                    break;

                case "24":
                    dado.Tecnico.Uf = "MT";
                    break;

                case "25":
                    dado.Tecnico.Uf = "MS";
                    break;

                case "26":
                    dado.Tecnico.Uf = "GO";
                    break;

                case "27":
                    dado.Tecnico.Uf = "DF";
                    break;
            }

            return View("CurriculoEncontrado", dado);

        }

        public IActionResult PaginaConsulta()
        {
            return View();
        }

        private void PreparaListaEstadosParaCombo()
        {
            EstadoDAO estadoDAO = new EstadoDAO();
            var estados = estadoDAO.ListaEstados();
            List<SelectListItem> listaEstados = new List<SelectListItem>(); // se der erro, tente outra biblioteca
            listaEstados.Add(new SelectListItem("Selecione um estado...", "0"));

            foreach (var estado in estados)
            {
                SelectListItem item = new SelectListItem(estado.Nome, estado.Id.ToString());
                listaEstados.Add(item);
            }
            ViewBag.Estados = listaEstados;
        }

        public IActionResult Salvar(DadoViewModel dado, string Operacao)
        {            
            try
            {
                ValidaDados(dado, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    return View("Cadastro", dado);
                }

                else
                {
                    CurriculoDAO dao = new CurriculoDAO();
                    EnderecoDAO edao = new EnderecoDAO();
                    GraduacaoDAO gdao = new GraduacaoDAO();
                    PosGraduacaoDAO pgdao = new PosGraduacaoDAO();
                    TecnicoDAO tecdao = new TecnicoDAO();
                    ExperienciaDAO exdao = new ExperienciaDAO();
                    IdiomaDAO idao = new IdiomaDAO();
                    dado.Curriculo.Id = dao.ProximoId();
                    dado.Endereco.Id = edao.ProximoId();
                    dado.Curriculo.CodEndereco = dado.Endereco.Id;
                    dado.Endereco.IdCurriculo = dado.Curriculo.Id;
                    dado.Graduacao.IdFormacao = gdao.ProximoId();
                    dado.Graduacao.IdCurriculo = dado.Curriculo.Id;
                    dado.PosGraduacao.IdFormacao = pgdao.ProximoId();
                    dado.PosGraduacao.IdCurriculo = dado.Curriculo.Id;
                    dado.Tecnico.IdFormacao = tecdao.ProximoId();
                    dado.Tecnico.IdCurriculo = dado.Curriculo.Id;
                    dado.Experiencia.Id = exdao.ProximoId();
                    dado.Experiencia.IdCurriculo = dado.Curriculo.Id;
                    dado.Curriculo.IdExperiencia = dado.Experiencia.Id;
                    dado.Curriculo.IdFormacaoG = dado.Graduacao.IdFormacao;
                    dado.Curriculo.IdFormacaoPG = dado.PosGraduacao.IdFormacao;
                    dado.Curriculo.IdFormacaoTec = dado.Tecnico.IdFormacao;

                    if (dado.Idioma1 != null)
                    {
                        dado.Curriculo.IdIdioma1 = dado.Idioma1.IdIdioma;
                    }

                    if (dado.Idioma2 != null)
                    {
                        dado.Curriculo.IdIdioma2 = dado.Idioma2.IdIdioma;
                    }

                    if (dado.Idioma3 != null)
                    {
                        dado.Curriculo.IdIdioma3 = dado.Idioma3.IdIdioma;
                    }

                    if (dado.PosGraduacao.Inicio < Convert.ToDateTime("01/01/1900") || dado.PosGraduacao.Conclusao < Convert.ToDateTime("01/01/1900"))
                    {
                        dado.PosGraduacao.Inicio = Convert.ToDateTime("01/01/1900");
                        dado.PosGraduacao.Conclusao = Convert.ToDateTime("01/01/1900");
                    }

                    if (dado.Experiencia.Inicio < Convert.ToDateTime("01/01/1900") || dado.Experiencia.Fim < Convert.ToDateTime("01/01/1900"))
                    {
                        dado.Experiencia.Inicio = Convert.ToDateTime("01/01/1900");
                        dado.Experiencia.Fim = Convert.ToDateTime("01/01/1900");
                    }

                    if (dado.Graduacao.Inicio < Convert.ToDateTime("01/01/1900") || dado.Graduacao.Conclusao < Convert.ToDateTime("01/01/1900"))
                    {
                        dado.Graduacao.Inicio = Convert.ToDateTime("01/01/1900");
                        dado.Graduacao.Conclusao = Convert.ToDateTime("01/01/1900");
                    }

                    if (dado.Tecnico.Inicio < Convert.ToDateTime("01/01/1900") || dado.Tecnico.Conclusao < Convert.ToDateTime("01/01/1900"))
                    {
                        dado.Tecnico.Inicio = Convert.ToDateTime("01/01/1900");
                        dado.Tecnico.Conclusao = Convert.ToDateTime("01/01/1900");
                    }

                    if (dado.Graduacao.Instituicao == null)
                    {
                        dado.Graduacao.Instituicao = "NULL";
                    }

                    if (dado.PosGraduacao.Instituicao == null)
                    {
                        dado.PosGraduacao.Instituicao = "NULL";
                    }

                    if (dado.Tecnico.Instituicao == null)
                    {
                        dado.Tecnico.Instituicao = "NULL";
                    }

                    if (dado.Graduacao.Cidade == null)
                    {
                        dado.Graduacao.Cidade = "NULL";
                    }

                    if (dado.PosGraduacao.Cidade == null)
                    {
                        dado.PosGraduacao.Cidade = "NULL";
                    }

                    if (dado.Tecnico.Cidade == null)
                    {
                        dado.Tecnico.Cidade = "NULL";
                    }

                    if (dado.Graduacao.Curso == null)
                    {
                        dado.Graduacao.Curso = "NULL";
                    }

                    if (dado.PosGraduacao.Curso == null)
                    {
                        dado.PosGraduacao.Curso = "NULL";
                    }

                    if (dado.Tecnico.Curso == null)
                    {
                        dado.Tecnico.Curso = "NULL";
                    }

                    if (dado.Experiencia.NomeDaEmpresa == null)
                    {
                        dado.Experiencia.NomeDaEmpresa = "NULL";
                    }

                    if (dado.Experiencia.Cargo == null)
                    {
                        dado.Experiencia.Cargo = "NULL";
                    }

                    //dao.Inserir(dado.Curriculo);
                    if (Operacao == "I" || string.IsNullOrEmpty(Operacao))
                    {
                        edao.Inserir(dado.Endereco);
                        gdao.Inserir(dado.Graduacao);
                        pgdao.Inserir(dado.PosGraduacao);
                        tecdao.Inserir(dado.Tecnico);
                        exdao.Inserir(dado.Experiencia);
                    }
                    else
                    {
                        edao.Alterar(dado.Endereco);
                        gdao.Alterar(dado.Graduacao);
                        pgdao.Alterar(dado.PosGraduacao);
                        tecdao.Alterar(dado.Tecnico);
                        exdao.Alterar(dado.Experiencia);
                    }
                                        
                    if (dado.Idioma1 != null && dado.Idioma1.Idioma == null)
                    {
                        dado.Idioma1.Idioma = "NULL";
                    }

                    if (dado.Idioma2 != null && dado.Idioma2.Idioma == null)
                    {
                        dado.Idioma2.Idioma = "NULL";
                    }

                    if (dado.Idioma3 != null && dado.Idioma3.Idioma == null)
                    {
                        dado.Idioma3.Idioma = "NULL";
                    }

                    if (dado.Idioma1 != null)
                    {
                        dado.Idioma1.IdIdioma = idao.ProximoId();
                        dado.Idioma1.IdCurriculo = dado.Curriculo.Id;
                        dado.Curriculo.IdIdioma1 = dado.Idioma1.IdIdioma;
                    }

                    if (dado.Idioma1 != null)
                    {
                        if (Operacao == "I" || string.IsNullOrEmpty(Operacao))
                        {
                            idao.Inserir(dado.Idioma1);
                        }

                        else
                        {
                            idao.Alterar(dado.Idioma1);
                        }
                    }

                    if (dado.Idioma2 != null)
                    {
                        dado.Idioma2.IdIdioma = idao.ProximoId();
                        dado.Idioma2.IdCurriculo = dado.Curriculo.Id;
                        dado.Curriculo.IdIdioma2 = dado.Idioma2.IdIdioma;
                    }

                    if (dado.Idioma2 != null)
                    {
                        if (Operacao == "I" || string.IsNullOrEmpty(Operacao))
                        {
                            idao.Inserir(dado.Idioma2);
                        }

                        else
                        {
                            idao.Alterar(dado.Idioma2);
                        }
                    }

                    if (dado.Idioma3 != null)
                    {
                        dado.Idioma3.IdIdioma = idao.ProximoId();
                        dado.Idioma3.IdCurriculo = dado.Curriculo.Id;
                        dado.Curriculo.IdIdioma3 = dado.Idioma3.IdIdioma;
                    }

                    if (dado.Idioma3 != null)
                    {
                        if (Operacao == "I" || string.IsNullOrEmpty(Operacao))
                        {
                            idao.Inserir(dado.Idioma3);
                        }

                        else
                        {
                            idao.Alterar(dado.Idioma3);
                        }

                    }

                    if (Operacao == "I" || string.IsNullOrEmpty(Operacao))
                    {
                        dao.Inserir(dado.Curriculo);
                    }

                    else
                    {
                        dao.Alterar(dado.Curriculo);
                    }

                    return RedirectToAction("Cadastro");
                }
            }
            catch (Exception e)
            {
                return View("Error", new ErrorViewModel(e.Message));
            }
        }

        private void PreparaListaGraduacoesParaCombo()
        {
            TipoGraduacaoDAO gradDAO = new TipoGraduacaoDAO();
            var graduacoes = gradDAO.ListaGraduacoes();
            List<SelectListItem> listaGraduacoes = new List<SelectListItem>(); // se der erro, tente outra biblioteca
            listaGraduacoes.Add(new SelectListItem("Selecione um tipo...", "0"));

            foreach (var graduacao in graduacoes)
            {
                SelectListItem item = new SelectListItem(graduacao.Descricao, graduacao.Id.ToString());
                listaGraduacoes.Add(item);
            }
            ViewBag.TiposGraduacao = listaGraduacoes;
        }

        private void PreparaListaPosGraduacoesParaCombo()
        {
            TipoPosDAO gradDAO = new TipoPosDAO();
            var pos = gradDAO.ListaPos();
            List<SelectListItem> listaPosGraduacoes = new List<SelectListItem>(); // se der erro, tente outra biblioteca
            listaPosGraduacoes.Add(new SelectListItem("Selecione um tipo...", "0"));

            foreach (var p in pos)
            {
                SelectListItem item = new SelectListItem(p.Descricao, p.Id.ToString());
                listaPosGraduacoes.Add(item);
            }
            ViewBag.TiposPosGraduacao = listaPosGraduacoes;
        }

        private void PreparaListaTurnosParaCombo()
        {
            TurnoDAO tDAO = new TurnoDAO();
            var turnos = tDAO.ListaTurnos();
            List<SelectListItem> listaTurnos = new List<SelectListItem>(); // se der erro, tente outra biblioteca
            listaTurnos.Add(new SelectListItem("Selecione um turno...", "0"));

            foreach (var turno in turnos)
            {
                SelectListItem item = new SelectListItem(turno.Texto, turno.Id.ToString());
                listaTurnos.Add(item);
            }
            ViewBag.Turnos = listaTurnos;
        }

        private void PreparaListaNiveisParaCombo()
        {
            NivelDAO nDAO = new NivelDAO();
            var niveis = nDAO.ListaNiveis();
            List<SelectListItem> listaIdiomas = new List<SelectListItem>(); // se der erro, tente outra biblioteca
            listaIdiomas.Add(new SelectListItem("Selecione um nível...", "0"));

            foreach (var nivel in niveis)
            {
                SelectListItem item = new SelectListItem(nivel.Descricao, nivel.IdNivel.ToString());
                listaIdiomas.Add(item);
            }
            ViewBag.Niveis = listaIdiomas;
        }

        private void ValidaDados(DadoViewModel dado, string operacao)
        {
            ModelState.Clear();

            if (string.IsNullOrEmpty(dado.Curriculo.Nome))
            {
                ModelState.AddModelError("Curriculo.Nome", "Nome completo obrigatório.");
            }

            if (dado.Curriculo.Nome.Trim().Length > 50)
            {
                ModelState.AddModelError("Curriculo.Nome", "Nome não pode passar de 50 caracteres.");
            }

            if (dado.Curriculo.Idade == 0 || dado.Curriculo.Idade < 14)
            {
                ModelState.AddModelError("Curriculo.Idade", "Idade Inválida.");
            }

            if (dado.Curriculo.Cpf.Trim().Length > 14 || dado.Curriculo.Cpf.Trim().Length < 14)
            {
                ModelState.AddModelError("Curriculo.Cpf", "O CPF deve conter 14 caracteres, incluindo pontos e traço.");
            }

            if (string.IsNullOrEmpty(dado.Curriculo.Cpf))
            {
                ModelState.AddModelError("Curriculo.Cpf", "Campo obrigatório.");
            }

            if (dado.Curriculo.Cpf.Trim().Length > 14)
            {
                ModelState.AddModelError("Curriculo.Telefone", "O telefone não pode ter mais de 14 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Curriculo.Email))
            {
                ModelState.AddModelError("Curriculo.Email", "Campo obrigatório.");
            }

            if (dado.Curriculo.Email.IndexOf('@') == -1)
            {
                ModelState.AddModelError("Curriculo.Email", "E-mail inválido.");
            }

            if (dado.Curriculo.Email.Trim().Length > 50)
            {
                ModelState.AddModelError("Curriculo.Email", "E-mail não pode ter mais de 50 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Curriculo.Area))
            {
                ModelState.AddModelError("Curriculo.Area", "Campo obrigatório.");
            }

            if (dado.Curriculo.Area.Trim().Length > 20)
            {
                ModelState.AddModelError("Curriculo.Area", "A área não pode ter mais de 20 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Curriculo.Cargo))
            {
                ModelState.AddModelError("Curriculo.Cargo", "Campo obrigatório.");
            }

            if (dado.Curriculo.Cargo.Trim().Length > 50)
            {
                ModelState.AddModelError("Curriculo.Cargo", "O cargo não pode ter mais de 50 caracteres.");
            }

            if (dado.Endereco.Cidade.Trim().Length > 50)
            {
                ModelState.AddModelError("Endereco.Cidade", "A cidade não pode ter mais de 50 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Endereco.Cidade))
            {
                ModelState.AddModelError("Endereco.Cidade", "Campo obrigatório.");
            }

            if (dado.Endereco.Bairro.Trim().Length > 50)
            {
                ModelState.AddModelError("Endereco.Bairro", "O bairro não pode ter mais de 50 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Endereco.Bairro))
            {
                ModelState.AddModelError("Endereco.Bairro", "Campo obrigatório.");
            }

            if (dado.Endereco.Rua.Trim().Length > 50)
            {
                ModelState.AddModelError("Endereco.Rua", "A rua não pode ter mais de 50 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Endereco.Rua))
            {
                ModelState.AddModelError("Endereco.Rua", "Campo obrigatório.");
            }

            if (dado.Endereco.Cep.Trim().Length > 9)
            {
                ModelState.AddModelError("Endereco.Cep", "O CEP não pode ter mais de 9 caracteres.");
            }

            if (string.IsNullOrEmpty(dado.Endereco.Cep))
            {
                ModelState.AddModelError("Endereco.Cep", "Campo obrigatório.");
            }
        }

        public IActionResult Editar(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                DadoDAO dao = new DadoDAO();
                DadoViewModel dado = dao.Consulta(id);
                PreparaListaEstadosParaCombo();
                PreparaListaGraduacoesParaCombo();
                PreparaListaNiveisParaCombo();
                PreparaListaPosGraduacoesParaCombo();
                PreparaListaTurnosParaCombo();
                
                if (dado == null)
                    return View("Cadastro");
                else
                    return View("Cadastro", dado);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}
