#pragma checksum "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9895268d5d225205b877da559d19310b3308696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Listar), @"mvc.1.0.view", @"/Views/Comentario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Listar.cshtml", typeof(AspNetCore.Views_Comentario_Listar))]
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
#line 1 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
using Check_Point.Models;

#line default
#line hidden
#line 2 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9895268d5d225205b877da559d19310b3308696", @"/Views/Comentario/Listar.cshtml")]
    public class Views_Comentario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
  
    ViewBag.Title = "Listar Comentário";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(147, 70, true);
            WriteLiteral("\r\n<h1>Lista de Comentários Cadastrados (Aguardando Aprovação)</h3>\r\n\r\n");
            EndContext();
            BeginContext(246, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1121, 28, true);
            WriteLiteral("\r\n<div class=\"comentario\">\r\n");
            EndContext();
#line 54 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
     foreach (var item in ViewData["Comentarios"] as List<ComentarioModel>)
        {

#line default
#line hidden
            BeginContext(1237, 385, true);
            WriteLiteral(@"            <ol>
                <li>
                    <div>

                        <div class=""topo-comentario"">
                            <div class=""avatar"">
                                <img class=""img-avatar"" src=""/Imagens/user.png"">
                            </div>

                            <div class=""comentario-nome"">
                                ");
            EndContext();
            BeginContext(1623, 17, false);
#line 66 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
                           Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 233, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        \r\n                        <div class=\"comentario-texto\">\r\n                            <p class=\"p-texto\">\r\n                                ");
            EndContext();
            BeginContext(1874, 10, false);
#line 72 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
                           Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1884, 177, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        \r\n                        <div class=\"comentario-data\">\r\n                            ");
            EndContext();
            BeginContext(2062, 16, false);
#line 77 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
                       Write(item.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 104, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n            </ol>\r\n");
            EndContext();
#line 82 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\Listar.cshtml"
        } 

#line default
#line hidden
            BeginContext(2194, 133, true);
            WriteLiteral("</div>\r\n\r\n    <a  id=\"btn-big\" class=btn-enviar style=\"display:block\" href=\"/Comentario/Cadastrar\"> Cadastrar outro comentário </a>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
