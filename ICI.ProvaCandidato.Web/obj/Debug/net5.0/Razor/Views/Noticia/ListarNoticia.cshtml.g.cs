#pragma checksum "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e62a873fbe7ee10ddc39ed40e1bb3b94ed22bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticia_ListarNoticia), @"mvc.1.0.view", @"/Views/Noticia/ListarNoticia.cshtml")]
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
#line 1 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\_ViewImports.cshtml"
using ICI.ProvaCandidato.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
using ICI.ProvaCandidato.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e62a873fbe7ee10ddc39ed40e1bb3b94ed22bf7", @"/Views/Noticia/ListarNoticia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd312efccbabd6db444d6f769f6f349e825333a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Noticia_ListarNoticia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
  
    ViewBag.Title = "ListarTags";
    List<NoticiaModel> lstNoticia = ViewBag.LstNoticia;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section>
    <div class=""container"">
        <div class=""col-lg-12 text-center"">
            <h3>Notícias</h3>
        </div>
        <div class=""row text-right"" style=""display:block"">
            <a href=""/Noticia/CadastrarNoticia/"" title=""Cadastrar Notícia"" class=""btn btn-primary"">
                <span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>
                Novo
            </a>
        </div>
        <div class=""col-lg-12"" style=""display:flex; justify-content:center; margin-top:10px;"">
            <div class=""col-lg-10"">
                <table class=""table table-condensed table-bordered table-striped dataTable"">
                    <thead>
                        <tr>
                            <th class=""text-center"">Ações</th>
                            <th class=""text-center"">Código</th>
                            <th class=""text-center"">Título</th>
                            <th class=""text-center"">Texto</th>
                            <th class=""text-cent");
            WriteLiteral("er\">Usuário</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                         if (lstNoticia != null && lstNoticia.Count > 0)
                        {
                            foreach (var item in lstNoticia)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <a title=\"Editar Noticia\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1654, "\"", 1687, 3);
            WriteAttributeValue("", 1664, "EditarNoticia(", 1664, 14, true);
#nullable restore
#line 37 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
WriteAttributeValue("", 1678, item.Id, 1678, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1686, ")", 1686, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"bi bi-pencil\" style=\"color:white;\"></i>\r\n                                        </a>\r\n                                        <a title=\"Excluir Noticia\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1922, "\"", 1956, 3);
            WriteAttributeValue("", 1932, "ExcluirNoticia(", 1932, 15, true);
#nullable restore
#line 40 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
WriteAttributeValue("", 1947, item.Id, 1947, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1955, ")", 1955, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""bi bi-trash"" style=""color:white;""></i>
                                        </a>
                                    </td>
                                    <td class=""text-center"">
                                        ");
#nullable restore
#line 45 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 48 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div id=\"erro\" style=\"display: none; color: red;\"></div>\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 52 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                                   Write(item.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 55 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                                   Write(item.NmUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                            }
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td colspan=""5"" class=""text-center"">
                                    <label>Não contém notícias cadastradas!</label>
                                </td>
                            </tr>
");
#nullable restore
#line 66 "C:\Users\romul\Documents\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\ListarNoticia.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
