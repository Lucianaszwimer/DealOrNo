#pragma checksum "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241635dead4de6e03ac2567ec65422960e54500b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_index), @"mvc.1.0.view", @"/Views/Juego/index.cshtml")]
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
#line 1 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\_ViewImports.cshtml"
using DealOrNoDeal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\_ViewImports.cshtml"
using DealOrNoDeal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241635dead4de6e03ac2567ec65422960e54500b", @"/Views/Juego/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86736966829baa866f91930286ed600eeeaaf9cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
  
    ViewData["Title"] = "IndexJuego";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241635dead4de6e03ac2567ec65422960e54500b3249", async() => {
                WriteLiteral(@"
<div class=""container"">
<div class=""container-Juego"" > 
    <div class=""text-center text-white"" > 
        <h1>??Que comience el juego!</h1>
        <h2>Para comenzar, eleg?? el malet??n que m??s te guste.</h2>
    </div>   
</div> 
</div>
    <div class=""importesIzq""> 
");
#nullable restore
#line 14 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
         for(int i=0; i<13; i++){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div >\r\n                <p class=\"cajaImporte\"> $");
#nullable restore
#line 16 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
                                    Write(ViewBag.importe[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div class=\"importesDer\"> \r\n");
#nullable restore
#line 21 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
         for(int j=13; j<26; j++){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <p class=\"cajaImporte\"> $");
#nullable restore
#line 23 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
                                    Write(ViewBag.importe[j]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n     <div class=\"maletines col-6\"> \r\n");
#nullable restore
#line 28 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
         for(int k=0; k<26; k++){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\'", 778, "\'", 848, 1);
#nullable restore
#line 29 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
WriteAttributeValue("", 785, Url.Action("elegirPrimerMaletin","Juego", new { maletin = k }), 785, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <img class=\"maletin\"");
                BeginWriteAttribute("src", "src=\"", 888, "\"", 931, 3);
                WriteAttributeValue("", 893, "/Imagenes/Maletines/maletin", 893, 27, true);
#nullable restore
#line 30 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
WriteAttributeValue(" ", 920, k+1, 921, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 927, ".png", 927, 4, true);
                EndWriteAttribute();
                WriteLiteral(" >  </a>\r\n");
#nullable restore
#line 31 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   ");
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
