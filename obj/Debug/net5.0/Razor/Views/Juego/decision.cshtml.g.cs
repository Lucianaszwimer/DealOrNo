#pragma checksum "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89a0c365b98344a7bb909f923501aaa08ff018a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_decision), @"mvc.1.0.view", @"/Views/Juego/decision.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a0c365b98344a7bb909f923501aaa08ff018a8", @"/Views/Juego/decision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86736966829baa866f91930286ed600eeeaaf9cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_decision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
  
    ViewData["Title"] = "Decision";
    int k = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89a0c365b98344a7bb909f923501aaa08ff018a83281", async() => {
                WriteLiteral("\r\n<div class=\"container-Juego\" > \r\n    <div class=\"text-center text-white\" > \r\n");
#nullable restore
#line 8 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
         if (@ViewBag.Turno == 0){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3>??Desea aceptar la oferta de cambiar su maletin o se queda con la eleccion del principio?</h3>\r\n");
#nullable restore
#line 10 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
             while(k<25 && @ViewBag.Maletines[k].Estado==true){
                k++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <img class=\"maletin\"");
                BeginWriteAttribute("src", "src=\"", 426, "\"", 469, 3);
                WriteAttributeValue("", 431, "/Imagenes/Maletines/maletin", 431, 27, true);
#nullable restore
#line 13 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue(" ", 458, k+1, 459, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 465, ".png", 465, 4, true);
                EndWriteAttribute();
                WriteLiteral(" >\r\n            <img class=\"maletin\"");
                BeginWriteAttribute("src", "src=\"", 506, "\"", 579, 3);
                WriteAttributeValue("", 511, "/Imagenes/Maletines/maletin", 511, 27, true);
#nullable restore
#line 14 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue(" ", 538, ViewBag.elegido.NumeroDeMaletin+1, 539, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 575, ".png", 575, 4, true);
                EndWriteAttribute();
                WriteLiteral(" >\r\n        <a  class=\"btn-lg btn-warning\" style=\"margin-right: 1rem; margin-bottom: 2rem;\"");
                BeginWriteAttribute("href", " href=\'", 671, "\'", 754, 1);
#nullable restore
#line 15 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue("", 678, Url.Action("final", "Juego", new { decision = "true", MaletinCerrado = k} ), 678, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Cambiar</a>\r\n        <a  class=\"btn-lg btn-warning\" style=\"margin-left: 1rem; margin-bottom: 2rem;\"");
                BeginWriteAttribute("href", " href=\'", 855, "\'", 920, 1);
#nullable restore
#line 16 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue("", 862, Url.Action("final", "Juego", new { decision = "false" } ), 862, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Permanecer</a>\r\n");
#nullable restore
#line 17 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
        }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>Oferta de la banca: $");
#nullable restore
#line 18 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                            Write(string.Format("{0:#,0.00}", ViewBag.OfertaBanca));

#line default
#line hidden
#nullable disable
                WriteLiteral("  </h1>\r\n        <h5>Importe del malet??n abierto: $");
#nullable restore
#line 19 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                                     Write(ViewBag.ImporteMaletin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <h4>??Desea aceptar la oferta o seguir jugando por el maletin que usted eligio?</h4>\r\n    <center>\r\n        <a class=\"btn-lg btn-warning\" style=\"margin-right: 1rem; margin-bottom: 2rem;\"");
                BeginWriteAttribute("href", " href=\'", 1310, "\'", 1377, 1);
#nullable restore
#line 22 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue("", 1317, Url.Action("decision", "Juego", new { decision = "true" } ), 1317, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Aceptar</a>\r\n        <a class=\"btn-lg btn-warning\" style=\"margin-left: 1rem; margin-bottom: 2rem;\"");
                BeginWriteAttribute("href", " href=\'", 1477, "\'", 1545, 1);
#nullable restore
#line 23 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
WriteAttributeValue("", 1484, Url.Action("decision", "Juego", new { decision = "false" } ), 1484, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Rechazar</a>\r\n    </center>\r\n");
#nullable restore
#line 25 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div> \r\n    <div class = \"importesIzq\" >\r\n");
#nullable restore
#line 28 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
             for (int i=0; i<13; i++){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                 if(ViewBag.ImportesDescartados.Contains(@ViewBag.importes[i])){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporteAbierta\" type=\"button\" >$");
#nullable restore
#line 30 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                                                                  Write(ViewBag.Importes[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><br>\r\n");
#nullable restore
#line 31 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
               
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporte\" type=\"button\" >$");
#nullable restore
#line 33 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                                                           Write(ViewBag.Importes[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button> <br>\r\n");
#nullable restore
#line 34 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div> \r\n        \r\n        <div class = \"importesDer\" >\r\n");
#nullable restore
#line 39 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
             for (int f=13; f<26; f++){
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                     if(ViewBag.ImportesDescartados.Contains(@ViewBag.importes[f])){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporteAbierta\" type=\"button\" >$");
#nullable restore
#line 41 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                                                                  Write(ViewBag.Importes[f]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><br>\r\n");
#nullable restore
#line 42 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporte\" type=\"button\" >$");
#nullable restore
#line 43 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                                                           Write(ViewBag.Importes[f]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button> <br>\r\n");
#nullable restore
#line 44 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\decision.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br><br><br><br><br><br>\r\n    </div>\r\n    </div>\r\n");
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
            WriteLiteral("  ");
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
