#pragma checksum "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3695ba7e1240c3a71d9cacb5818dba1c33237f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo_CurriculoEncontrado), @"mvc.1.0.view", @"/Views/Curriculo/CurriculoEncontrado.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\_ViewImports.cshtml"
using CVMAKER_N2_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\_ViewImports.cshtml"
using CVMAKER_N2_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3695ba7e1240c3a71d9cacb5818dba1c33237f5", @"/Views/Curriculo/CurriculoEncontrado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898e9aa13c802107b962efab41c0dfb9d82533b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculo_CurriculoEncontrado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DadoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
   Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"divCustomizada\">\r\n    <label class=\"idDoCurriculo\">ID: ");
#nullable restore
#line 7 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                Write(Model.Curriculo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> \r\n    <br />\r\n    <br />\r\n    <div class=\"text-center\">\r\n        <h1>");
#nullable restore
#line 11 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
       Write(Model.Curriculo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <hr />\r\n    <label class=\"informacoes\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
   Write(Model.Curriculo.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos | ");
#nullable restore
#line 15 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                 Write(Model.Endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                          Write(Model.Endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                                  Write(Model.Endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                                                          Write(Model.Endereco.Rua);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 16 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
   Write(Model.Endereco.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 16 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                         Write(Model.Curriculo.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 16 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                     Write(Model.Curriculo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 16 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                              Write(Model.Curriculo.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </label>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <h3 class=\"h3Curriculo\">Objetivo</h3>\r\n    <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n        <li class=\"espacamento\"><label class=\"letra\">Atuar na área de ");
#nullable restore
#line 23 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                 Write(Model.Curriculo.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </label> </li>\r\n        <li class=\"espacamento\"><label class=\"letra\">");
#nullable restore
#line 24 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                Write(Model.Curriculo.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </label></li>\r\n    </ul>\r\n    <br />\r\n\r\n    <h3 class=\"h3Curriculo\">Formação acadêmica</h3>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
     if (Model.PosGraduacao.Instituicao != "NULL" && Model.PosGraduacao.Curso != "NULL")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n            <li class=\"espacamento\">\r\n                <label class=\"letra\"><b>  ");
#nullable restore
#line 34 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                     Write(Model.PosGraduacao.Instituicao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </label> <br />\r\n                <label class=\"letra\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.PosGraduacao.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em ");
#nullable restore
#line 36 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                           Write(Model.PosGraduacao.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Início: ");
#nullable restore
#line 36 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                               Write(Model.PosGraduacao.Inicio.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 36 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                                                                Write(Model.PosGraduacao.Inicio.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    Conclusão: ");
#nullable restore
#line 37 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                          Write(Model.PosGraduacao.Conclusao.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 37 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                              Write(Model.PosGraduacao.Conclusao.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 38 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.PosGraduacao.Conclusao > DateTime.Now)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Turno: ");
#nullable restore
#line 41 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                Write(Model.PosGraduacao.Turno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </label>\r\n");
#nullable restore
#line 42 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.PosGraduacao.Periodo != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Cursando: ");
#nullable restore
#line 45 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                   Write(Model.PosGraduacao.Periodo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" º período | </label>\r\n");
#nullable restore
#line 46 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.PosGraduacao.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 48 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                            Write(Model.PosGraduacao.Uf);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </label>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 53 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
     if (Model.Graduacao.Instituicao != "NULL" && Model.Graduacao.Curso != "NULL") // Se a pessoa fez ou faz faculdade
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n            <li class=\"espacamento\">\r\n                <label class=\"letra\"><b>  ");
#nullable restore
#line 59 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                     Write(Model.Graduacao.Instituicao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </label> <br />\r\n                <label class=\"letra\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.Graduacao.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em ");
#nullable restore
#line 61 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                        Write(Model.Graduacao.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Início: ");
#nullable restore
#line 61 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                         Write(Model.Graduacao.Inicio.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 61 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                                                       Write(Model.Graduacao.Inicio.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    Conclusão: ");
#nullable restore
#line 62 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                          Write(Model.Graduacao.Conclusao.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 62 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                           Write(Model.Graduacao.Conclusao.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 63 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.Graduacao.Conclusao > DateTime.Now) // Se a pessoa ainda não se formou, ela procura um estágio ou algo parecido. A empresa quer saber quando ela estuda.
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Turno: ");
#nullable restore
#line 66 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                Write(Model.Graduacao.Turno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </label>\r\n");
#nullable restore
#line 67 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.Graduacao.Periodo != 0) // Colocar o período como zero significa que se formou. Se é diferente de zero, ainda não se formou. A empresa quer saber qual é o semestre.
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Cursando: ");
#nullable restore
#line 70 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                   Write(Model.Graduacao.Periodo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" º período | </label>\r\n");
#nullable restore
#line 71 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 73 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.Graduacao.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 73 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                         Write(Model.Graduacao.Uf);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </label>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 78 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
     if (Model.Tecnico.Instituicao != "NULL" && Model.Tecnico.Curso != "NULL")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n            <li class=\"espacamento\">\r\n                <label class=\"letra\"><b>  ");
#nullable restore
#line 84 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                     Write(Model.Tecnico.Instituicao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </label> <br />\r\n                <label class=\"letra\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.Tecnico.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Início: ");
#nullable restore
#line 86 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                              Write(Model.Tecnico.Inicio.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 86 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                          Write(Model.Tecnico.Inicio.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    Conclusão: ");
#nullable restore
#line 87 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                          Write(Model.Tecnico.Conclusao.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 87 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                         Write(Model.Tecnico.Conclusao.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 88 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.Tecnico.Conclusao > DateTime.Now)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Turno: ");
#nullable restore
#line 91 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                Write(Model.Tecnico.Turno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </label>\r\n");
#nullable restore
#line 92 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                     if (Model.Tecnico.Periodo != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"letra\"> Cursando: ");
#nullable restore
#line 95 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                   Write(Model.Tecnico.Periodo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" º período | </label>\r\n");
#nullable restore
#line 96 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 98 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.Tecnico.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 98 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                       Write(Model.Tecnico.Uf);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </label>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 103 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
     if (Model.Experiencia.NomeDaEmpresa != "NULL" && Model.Experiencia.Cargo != "NULL")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"h3Curriculo\">Experiência</h3>\r\n        <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n            <li class=\"espacamento\">\r\n                <label class=\"letra\"><b>  ");
#nullable restore
#line 110 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                     Write(Model.Experiencia.NomeDaEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </label> <br />\r\n                <label class=\"letra\">\r\n                    ");
#nullable restore
#line 112 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
               Write(Model.Experiencia.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Início: ");
#nullable restore
#line 112 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                  Write(Model.Experiencia.Inicio.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 112 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                                                  Write(Model.Experiencia.Inicio.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    | Fim: ");
#nullable restore
#line 113 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                      Write(Model.Experiencia.Fim.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 113 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                                   Write(Model.Experiencia.Fim.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 117 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
     if (Model.Idioma1.Idioma != "NULL" || Model.Idioma2.Idioma != "NULL" || Model.Idioma3.Idioma != "NULL")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"h3Curriculo\">Idioma</h3>\r\n");
#nullable restore
#line 122 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
        if (Model.Idioma1.Idioma != "NULL" && Model.Idioma1.IdNivel != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n                <li class=\"espacamento\">\r\n                    <label class=\"letra\"><b>  ");
#nullable restore
#line 126 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                         Write(Model.Idioma1.Idioma);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b> </label>\r\n                    <label class=\"letra\">\r\n");
#nullable restore
#line 128 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                         switch (Model.Idioma1.IdNivel)
                        {
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Básico </label>\r\n");
#nullable restore
#line 132 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Intermediário </label>\r\n");
#nullable restore
#line 136 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Avançado </label>\r\n");
#nullable restore
#line 140 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Fluente </label>\r\n");
#nullable restore
#line 144 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </label>\r\n                </li>\r\n            </ul>\r\n");
#nullable restore
#line 149 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
        }

        if (Model.Idioma2.Idioma != "NULL" && Model.Idioma2.IdNivel != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n                <li class=\"espacamento\">\r\n                    <label class=\"letra\"><b>  ");
#nullable restore
#line 155 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                         Write(Model.Idioma2.Idioma);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b> </label>\r\n                    <label class=\"letra\">\r\n");
#nullable restore
#line 157 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                         switch (Model.Idioma2.IdNivel)
                        {
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Básico </label>\r\n");
#nullable restore
#line 161 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Intermediário </label>\r\n");
#nullable restore
#line 165 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Avançado </label>\r\n");
#nullable restore
#line 169 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Fluente </label>\r\n");
#nullable restore
#line 173 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </label>\r\n                </li>\r\n            </ul>\r\n");
#nullable restore
#line 178 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
        }

        if (Model.Idioma3.Idioma != "NULL" && Model.Idioma3.IdNivel != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul style=\"list-style-type:disc\" class=\"h3Curriculo\">\r\n                <li class=\"espacamento\">\r\n                    <label class=\"letra\"><b>  ");
#nullable restore
#line 184 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                         Write(Model.Idioma3.Idioma);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b> </label>\r\n                    <label class=\"letra\">\r\n");
#nullable restore
#line 186 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                         switch (Model.Idioma3.IdNivel)
                        {
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Básico </label>\r\n");
#nullable restore
#line 190 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Intermediário </label>\r\n");
#nullable restore
#line 194 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Avançado </label>\r\n");
#nullable restore
#line 198 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;

                            case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label class=\"letra\"> Fluente </label>\r\n");
#nullable restore
#line 202 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </label>\r\n                </li>\r\n            </ul>\r\n");
#nullable restore
#line 207 "C:\Users\Gabriel\Documents\CVMAKER_N2_\CVMAKER_N2_\Views\Curriculo\CurriculoEncontrado.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
