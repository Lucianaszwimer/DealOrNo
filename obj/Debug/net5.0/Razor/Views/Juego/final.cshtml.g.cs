#pragma checksum "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c76269519115556976aefaffb265aa2bbea6a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_final), @"mvc.1.0.view", @"/Views/Juego/final.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c76269519115556976aefaffb265aa2bbea6a7", @"/Views/Juego/final.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86736966829baa866f91930286ed600eeeaaf9cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_final : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
  
    ViewData["Title"] = "Final";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c76269519115556976aefaffb265aa2bbea6a73279", async() => {
                WriteLiteral("\r\n    <center>\r\n        <div class=\"text-center text-white\">\r\n");
#nullable restore
#line 8 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
             if(@ViewBag.Turno == -1){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                 if(@ViewBag.decision == "true"){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h1>Se gano 1$");
#nullable restore
#line 10 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                             Write(ViewBag.Maletines[ViewBag.MaletinCerrado].Importe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <h3>El importe de su maletin era $");
#nullable restore
#line 11 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                                                 Write(ViewBag.Maletines[ViewBag.elegido.NumeroDeMaletin].Importe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 12 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h1>Se gano $");
#nullable restore
#line 13 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                            Write(ViewBag.Maletines[ViewBag.elegido.NumeroDeMaletin].Importe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <h1>El importe del maletin sin abrir era $");
#nullable restore
#line 14 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                                                         Write(ViewBag.Maletines[ViewBag.MaletinCerrado].Importe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 15 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                 
            }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1>Se gano $");
#nullable restore
#line 17 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                        Write(string.Format("{0:#,0.00}",@ViewBag.OfertaBanca));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> <br>\r\n                <h3>El importe de su maletin era $");
#nullable restore
#line 18 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
                                             Write(ViewBag.Maletines[ViewBag.elegido.NumeroDeMaletin].Importe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 19 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\final.cshtml"
            }    

#line default
#line hidden
#nullable disable
                WriteLiteral("            \r\n            \r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"col-sm-10\">\r\n                <img class=\"imagenFinal\" src = \"/imagenes/Logo.png\" >\r\n            </div>\r\n        </div>\r\n    </center>\r\n");
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
