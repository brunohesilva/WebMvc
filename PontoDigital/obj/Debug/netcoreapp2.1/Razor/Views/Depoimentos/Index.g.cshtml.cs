#pragma checksum "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df12049bb824885c91af56b3d6097819db475ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depoimentos_Index), @"mvc.1.0.view", @"/Views/Depoimentos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depoimentos/Index.cshtml", typeof(AspNetCore.Views_Depoimentos_Index))]
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
#line 1 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\_ViewImports.cshtml"
using PontoDigital;

#line default
#line hidden
#line 2 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\_ViewImports.cshtml"
using PontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df12049bb824885c91af56b3d6097819db475ff1", @"/Views/Depoimentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b910b3ba7e7adee03aca8981fb32aa0bb2060f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Depoimentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimentos\Index.cshtml"
  
    ViewData["Title"] = "Depoimentos - PontoDigital";


#line default
#line hidden
            BeginContext(64, 12, true);
            WriteLiteral("\r\n<header>\r\n");
            EndContext();
#line 7 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimentos\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(137, 38, true);
            WriteLiteral("</header> \r\n\r\n<h2>Depoimentos</h2>\r\n\r\n");
            EndContext();
            BeginContext(175, 398, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f75c05efa9346d0a3a62b4d6e624315", async() => {
                BeginContext(181, 143, true);
                WriteLiteral("\r\n\r\n\r\n<div>\r\n    <label for=\"nome\">Nome Completo</label>\r\n    <br />\r\n    <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 324, "\"", 351, 1);
#line 20 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimentos\Index.cshtml"
WriteAttributeValue("", 332, Model.Cliente.Nome, 332, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(352, 214, true);
                WriteLiteral("/>\r\n</div>\r\n\r\n<div>\r\n    <label for=\"comentario\">Deixe seu Depoimento aqui</label>\r\n    <br />\r\n    <textarea name=\"comentário\" rows=\"10\" cols=\"40\"></textarea>\r\n</div>\r\n\r\n <input type=\"submit\" value=\"Comentar\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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