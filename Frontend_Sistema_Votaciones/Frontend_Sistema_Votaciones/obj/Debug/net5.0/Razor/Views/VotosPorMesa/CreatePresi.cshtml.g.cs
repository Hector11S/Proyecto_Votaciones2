#pragma checksum "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3c7e98f8a4146f22940ed6f3d7d89180d47de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VotosPorMesa_CreatePresi), @"mvc.1.0.view", @"/Views/VotosPorMesa/CreatePresi.cshtml")]
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
#line 1 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3c7e98f8a4146f22940ed6f3d7d89180d47de5", @"/Views/VotosPorMesa/CreatePresi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_VotosPorMesa_CreatePresi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_Sistema_Votaciones.Models.VotosPorMesasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePresi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
  
    ViewData["Title"] = "Create";
    var alcaldes = ViewBag.Alcaldes;
    var partidos = ViewBag.Partidos;
    var presidentes = ViewBag.Presidente;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .img-container {
        width: 100%;
        height: 200px;
        position: relative;
        overflow: hidden;
        text-align: center;
    }

        .img-container img {
            width: 100%;
            height: auto;
            margin: 0 auto;
            display: block;
        }

    .text-center {
        text-align: center;
    }

    .form-check {
        text-align: center;
    }

    .mb-4 {
        margin-bottom: 1rem;
    }

    .custom-radio .form-check-input {
        width: 25px;
        height: 25px;
        margin: 0 auto;
        display: block;
    }

    .custom-radio .form-check-label {
        display: none;
    }
</style>


<h1 style=""background-color: #3dbdd9"" class=""text-center"">Candidatos Para la Presidencia</h1>

<hr />
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be3c7e98f8a4146f22940ed6f3d7d89180d47de55452", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be3c7e98f8a4146f22940ed6f3d7d89180d47de55745", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VoMe_Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <div class=""text-center mt-4"">
            <div class=""btn-group"">
                <input style=""background-color: #3dbdd9; color: white; border-radius: 10px; padding: 10px 20px;"" type=""submit"" value=""Crear Voto"" class=""btn mr-2"" />
                <span style=""margin-right: 50px;""></span>
                <a class=""btn btn-secondary"" style=""border-radius: 10px; padding: 10px 20px;""");
                BeginWriteAttribute("href", " href=\"", 1605, "\"", 1632, 1);
#nullable restore
#line 62 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 1612, Url.Action("Index"), 1612, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Regresar</a>
            </div>
        </div>
        <br />
        <hr />

        <div class=""col-12 mb-4"">
            <div class=""border border-5 border-dark p-3"">
                <h1 class=""text-center"">Voto nulo</h1>
                <div class=""form-check custom-radio"" style=""margin: 0 auto; display: table;"">
                    <input style=""border-color:black"" class=""form-check-input"" type=""radio"" name=""VoMe_CandidatoId"" id=""rb-nulo"" value=""16"">

                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 78 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
             foreach (var presidente in presidentes)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                 if (presidente.Pres_Id != 16)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-4 mb-4\">\r\n                        <div class=\"border border-5 border-dark p-3\">\r\n                            <div class=\"img-container\">\r\n");
#nullable restore
#line 85 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                                 foreach (var partido in partidos)
                                {
                                    if (partido.Part_Id == presidente.Part_Id)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img");
                BeginWriteAttribute("src", " src=\"", 2773, "\"", 2799, 1);
#nullable restore
#line 89 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 2779, partido.Part_Imagen, 2779, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Imagen-partido-politico\" style=\"height: 200px;\">\r\n");
#nullable restore
#line 90 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"img-container\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 3059, "\"", 3088, 1);
#nullable restore
#line 94 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 3065, presidente.Pres_Imagen, 3065, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Imagen-alcalde\" style=\"height: 200px;\">\r\n                            </div>\r\n                            <br />\r\n");
#nullable restore
#line 97 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                             foreach (var votante in ViewBag.Votante)
                            {
                                if (votante.Vota_Id == presidente.Pres_Id)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <hr />\r\n                                    <h2 class=\"text-center mb-4\">");
#nullable restore
#line 102 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                                                            Write(votante.Vota_Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 102 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                                                                                 Write(votante.Vota_Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    <hr />\r\n");
#nullable restore
#line 104 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-check custom-radio\" style=\"margin: 0 auto; display: table;\">\r\n                                <input style=\"border-color:black\" class=\"form-check-input\" type=\"radio\" name=\"VoMe_CandidatoId\"");
                BeginWriteAttribute("id", " id=\"", 3925, "\"", 3959, 1);
#nullable restore
#line 107 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 3930, "rb-" + presidente.Pres_Id, 3930, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3960, "\"", 3987, 1);
#nullable restore
#line 107 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 3968, presidente.Pres_Id, 3968, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 111 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>


        <hr />
    </div>
    <div class=""text-center mt-4"">
        <div class=""btn-group"">
            <input style=""background-color: #3dbdd9; color: white; border-radius: 10px; padding: 10px 20px;"" type=""submit"" value=""Crear Voto"" class=""btn mr-2"" />
            <span style=""margin-right: 50px;""></span>
            <a class=""btn btn-secondary"" style=""border-radius: 10px; padding: 10px 20px;""");
                BeginWriteAttribute("href", " href=\"", 4547, "\"", 4574, 1);
#nullable restore
#line 123 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\CreatePresi.cshtml"
WriteAttributeValue("", 4554, Url.Action("Index"), 4554, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Regresar</a>\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Sistema_Votaciones.Models.VotosPorMesasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
