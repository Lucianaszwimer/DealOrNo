#pragma checksum "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a5cec264a5e88e26a532695332189d3bde6929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_juego), @"mvc.1.0.view", @"/Views/Juego/juego.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a5cec264a5e88e26a532695332189d3bde6929", @"/Views/Juego/juego.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86736966829baa866f91930286ed600eeeaaf9cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_juego : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
  
    ViewData["Title"] = "Juego";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8a5cec264a5e88e26a532695332189d3bde69293244", async() => {
                WriteLiteral("\r\n<div class=\"container-Juego\" > \r\n    <div class=\"text-center text-white\" > \r\n        <h1>Deal Or No Deal</h1>\r\n\r\n        <h3>Jugadas restantes: ");
#nullable restore
#line 9 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                          Write(ViewBag.JugadasRestantes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 10 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
         if(ViewBag.JugadasRestantes !=6 && ViewBag.volverJuego == "true"){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3>Importe del maletín abierto: $");
#nullable restore
#line 11 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                                         Write(ViewBag.ImporteMaletin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 12 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>   \r\n</div> \r\n        <div class = \"importesIzq\" >\r\n");
#nullable restore
#line 17 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
             for (int i=0; i<13; i++){
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                 if(ViewBag.ImportesDescartados.Contains(@ViewBag.importes[i])){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporteAbierta\" type=\"button\" >$");
#nullable restore
#line 19 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                                                                  Write(ViewBag.Importes[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><br>\r\n");
#nullable restore
#line 20 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
               
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporte\" type=\"button\" >$");
#nullable restore
#line 22 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                                                           Write(ViewBag.Importes[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button> <br>\r\n");
#nullable restore
#line 23 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div> \r\n        \r\n        <div class = \"importesDer\" >\r\n");
#nullable restore
#line 28 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
             for (int f=13; f<26; f++){
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                     if(ViewBag.ImportesDescartados.Contains(@ViewBag.importes[f])){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporteAbierta\" type=\"button\" >$");
#nullable restore
#line 30 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                                                                  Write(ViewBag.Importes[f]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><br>\r\n");
#nullable restore
#line 31 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button class=\"cajaImporte\" type=\"button\" >$");
#nullable restore
#line 32 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                                                           Write(ViewBag.Importes[f]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button> <br>\r\n");
#nullable restore
#line 33 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n     <div class=\"maletines col-6\"> \r\n");
#nullable restore
#line 37 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
         for(int k=0; k<26; k++){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
             if(@ViewBag.Maletines[k].Estado){

#line default
#line hidden
#nullable disable
                WriteLiteral("            <img class=\"maletin\"");
                BeginWriteAttribute("src", "src=\"", 1480, "\"", 1523, 3);
                WriteAttributeValue("", 1485, "/Imagenes/Maletines/maletin", 1485, 27, true);
#nullable restore
#line 39 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
WriteAttributeValue(" ", 1512, k+1, 1513, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1519, ".png", 1519, 4, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"opacity: 50%\">\r\n");
#nullable restore
#line 40 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
                }
            else{

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\'", 1600, "\'", 1666, 1);
#nullable restore
#line 42 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
WriteAttributeValue("", 1607, Url.Action("eleccionMaletin","Juego", new { maletin = k }), 1607, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <img class=\"maletin\"");
                BeginWriteAttribute("src", "src=\"", 1702, "\"", 1745, 3);
                WriteAttributeValue("", 1707, "/Imagenes/Maletines/maletin", 1707, 27, true);
#nullable restore
#line 43 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
WriteAttributeValue(" ", 1734, k+1, 1735, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1741, ".png", 1741, 4, true);
                EndWriteAttribute();
                WriteLiteral(" >  </a>\r\n");
#nullable restore
#line 44 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\faust\Downloads\DealOrNoDeal3(LO BORRASTE XD)\Views\Juego\juego.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n\r\n\r\n");
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
            WriteLiteral(" ");
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
