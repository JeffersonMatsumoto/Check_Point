#pragma checksum "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Shared\MasterPageDeslogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9496394508e526bf0552744acfa745bac8aba309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageDeslogado), @"mvc.1.0.view", @"/Views/Shared/MasterPageDeslogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageDeslogado.cshtml", typeof(AspNetCore.Views_Shared_MasterPageDeslogado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9496394508e526bf0552744acfa745bac8aba309", @"/Views/Shared/MasterPageDeslogado.cshtml")]
    public class Views_Shared_MasterPageDeslogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(38, 1161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a61c3c4aa504b679a41b60a9948adc8", async() => {
                BeginContext(44, 575, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:300,700,800"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.2.0/css/all.css"" integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"" crossorigin=""anonymous"">
    <script src=""/js/modal.js""></script>
    
    <!-- <link rel=""shortcut icon"" href=""""> -->

    <title> ");
                EndContext();
                BeginContext(620, 13, false);
#line 13 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Shared\MasterPageDeslogado.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(633, 559, true);
                WriteLiteral(@" </title>

    <link href=""/css/modal.css"" rel=""stylesheet"" type=""text/css""/>

    <link href=""/css/main.css"" rel=""stylesheet"" type=""text/css""/>
    <script src=""https://code.jquery.com/jquery-3.3.1.js"" integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60="" crossorigin=""anonymous""></script>
    <script>
        $(document).ready(function () {
            $('.toggle').click(function () {
                $('ul').toggleClass('active');
                $(this).find('i').toggleClass('fa-times');
            })
        })
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1199, 869, true);
            WriteLiteral(@"

    <div class=""topo"">
        <header>

            <div class=""logo"">
                <a href=""../Usuario/Cadastrar"">
                <img class=""logo-img"" src=""/Imagens/logotipo.png"" alt=""logotipo"">
                </a>
            </div>

            <div class=""toggle"">
                <i class=""fas fa-bars""></i>
            </div>

            <nav class=""menu"">

                <a class=""logo-escrito"" href=""../Usuario/Cadastrar"">Check Point</a>

                <ul class=""pages"">

                    <li>
                        <a href=""/Usuario/Cadastrar"">Cadastrar</a>
                    </li>
                    <li>
                        <a href=""/Usuario/Login"">Login</a>
                    </li>

                </ul>

            </nav>

        </header>
    </div>

    <div class=""conteudo-body"">
    ");
            EndContext();
            BeginContext(2069, 12, false);
#line 63 "C:\Users\ccgm1\Documents\Jefferson\CURSO\Projetos\Check_Point\Views\Shared\MasterPageDeslogado.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(2081, 509, true);
            WriteLiteral(@"
    </div>

    <footer>

        <a class=""logotipo-footer"" href=""../Usuario/Cadastrar"">
            <img class=""logo-img-footer"" src=""/Imagens/logotipo.png"" alt=""logotipo"">
        </a>

        <div class=""footer-final"">
                    <p>Escola SENAI de Informática</p>
            <p>© 2018 Carfel. Todos os direitos reservados </p>
            <p class=""bandeirinha"">Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo - SP, 01202-001</p>
        </div>

    </footer>
</html>");
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
