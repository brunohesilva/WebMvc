#pragma checksum "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71dfd769527145b98e59d803a9b05db21ed33595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depoimento_Index), @"mvc.1.0.view", @"/Views/Depoimento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depoimento/Index.cshtml", typeof(AspNetCore.Views_Depoimento_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71dfd769527145b98e59d803a9b05db21ed33595", @"/Views/Depoimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b910b3ba7e7adee03aca8981fb32aa0bb2060f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Depoimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 1 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimento\Index.cshtml"
      
        ViewData["Title"] = "Depoimento - PontoDigital";
    

#line default
#line hidden
            BeginContext(73, 16, true);
            WriteLiteral("\r\n    <header>\r\n");
            EndContext();
#line 6 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimento\Index.cshtml"
          
            Html.RenderPartial("_HeaderNavBar");
        

#line default
#line hidden
            BeginContext(162, 52, true);
            WriteLiteral("    </header> \r\n\r\n    <main id=\"depoimento\">\r\n\r\n    ");
            EndContext();
            BeginContext(214, 514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a92f68f971e4fd1840341376019aad5", async() => {
                BeginContext(281, 440, true);
                WriteLiteral(@"
    <div>
        <br />
        <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3"" name=""nome"" placeholder=""Nome""/>
        <br />
    </div>

    <div>
        <br />
        <label for=""depoimento"">Deixe seu Depoimento aqui</label>
        <br />
        <textarea name=""depoimento"" rows=""10"" cols=""40""></textarea>
        <br />
    </div>
    <br />
    <input type=""submit"" value=""Comentar"" />
    <br />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "C:\Users\38940293827\Documents\SenaiProjetos\WebMVC\WebMvc\PontoDigital\Views\Depoimento\Index.cshtml"
AddHtmlAttributeValue("", 242, Url.Action("Comentar", "Depoimento"), 242, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
