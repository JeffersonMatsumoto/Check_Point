#pragma checksum "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9106c569289d5781d3d1a314466dec259a3092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_ListarAtt), @"mvc.1.0.view", @"/Views/Comentario/ListarAtt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/ListarAtt.cshtml", typeof(AspNetCore.Views_Comentario_ListarAtt))]
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
#line 1 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
using Check_Point.Models;

#line default
#line hidden
#line 2 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9106c569289d5781d3d1a314466dec259a3092", @"/Views/Comentario/ListarAtt.cshtml")]
    public class Views_Comentario_ListarAtt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
  
    ViewBag.Title = "ListarAtt Comentário";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(150, 296, true);
            WriteLiteral(@"
<h1>Lista de Comentários</h3>

<table>

    <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Texto</th>
                <th>Data de Criação</th>
                <th>Status</th>
            </tr>
    </thead>
    
    <tbody>
");
            EndContext();
#line 23 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
         foreach (var item in ViewData["ComentariosAtt"] as List<ComentarioModel>)
        {

#line default
#line hidden
            BeginContext(541, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(602, 7, false);
#line 27 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(609, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(679, 17, false);
#line 31 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
               Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(696, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(766, 10, false);
#line 35 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
               Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(776, 101, true);
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td class=\"td-data\">\r\n                    ");
            EndContext();
            BeginContext(878, 16, false);
#line 39 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
               Write(item.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(894, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(964, 11, false);
#line 43 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
               Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(975, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Comentario\ListarAtt.cshtml"
        } 

#line default
#line hidden
            BeginContext(1031, 127, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n    <!-- <a style=\"display:block\" href=\"/Comentario/Cadastrar\"> Cadastrar outro comentário </a> -->\r\n");
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
