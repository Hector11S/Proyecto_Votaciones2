#pragma checksum "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b438b01542092af5b316022d9c4961af63a3ca28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VotosPorMesa_Index), @"mvc.1.0.view", @"/Views/VotosPorMesa/Index.cshtml")]
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
#line 1 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b438b01542092af5b316022d9c4961af63a3ca28", @"/Views/VotosPorMesa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_VotosPorMesa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend_Sistema_Votaciones.Models.VotosPorMesasViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
  
    var listaVotosAlcaldes = ViewBag.ListaVotosAlcaldes as IEnumerable<VotosPorMesasViewModel>;
    //var listaVotosAlcaldes = (List<VotosPorMesasViewModel>)ViewBag.ListaVotosAlcaldes;
    var listaVotosPresidentes = ViewBag.ListaVotosPresidentes as IEnumerable<VotosPorMesasViewModel>;
    var municipios = (List<MunicipioViewModel>)ViewBag.Municipios;
    var VotosPorMEsas = ViewBag.votosPorMesa as IEnumerable<VotosPorMesasViewModel>;
    var Muni_Codigo = ViewBag.Muni_Codigo;

    ViewData["Title"] = "VotosPorMesa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"w-100 d-flex justify-content-between align-items-center p-2 text-center\" style=\"background: rgb(255,255,255); min-height: 12vh;\">\r\n    <h1>Conteo de Votos</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b438b01542092af5b316022d9c4961af63a3ca285805", async() => {
                WriteLiteral("Votar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</header>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <div class=\"form-group\">\r\n            <label class=\"mb-2\" style=\"color: #3dbdd9\">Municipio: </label>\r\n            <select id=\"ddlMunicipios\" class=\"form-select\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b438b01542092af5b316022d9c4961af63a3ca287523", async() => {
                WriteLiteral("-- Seleccione un municipio --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                 if (municipios != null)
                {
                    foreach (var item in municipios)
                    {
                        if (item.Muni_Codigo == Muni_Codigo)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b438b01542092af5b316022d9c4961af63a3ca289222", async() => {
#nullable restore
#line 32 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                                                  Write(item.Muni_Descripcion);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                               WriteLiteral(item.Muni_Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b438b01542092af5b316022d9c4961af63a3ca2811889", async() => {
#nullable restore
#line 36 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                                         Write(item.Muni_Descripcion);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                               WriteLiteral(item.Muni_Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
            <span class=""text-danger""></span>
        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Alcaldes</h5>
                <div id=""pieChartAlcaldes""></div>
                <script>
                    var chartAlcaldes;

                    document.addEventListener(""DOMContentLoaded"", () => {
                        var seriesData = ");
#nullable restore
#line 57 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosAlcaldes.Select(m => m.TotalVotosAlcalde))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                        var labelsData = ");
#nullable restore
#line 58 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosAlcaldes.Select(m => m.NombreAlcalde + " " + m.ApellidoAlcalde))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                        var colorsData = ");
#nullable restore
#line 59 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosAlcaldes.Select(m => m.ColorPartido))));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

                        colorsData = colorsData.map(color => {
                            if (color === null) {
                                color = '000000';
                            }
                            if (!color.startsWith('#')) {
                                color = '#' + color;
                            }
                            return color;
                        });

                        chartAlcaldes = new ApexCharts(document.querySelector(""#pieChartAlcaldes""), {
                            series: seriesData,
                            chart: {
                                height: 350,
                                type: 'pie',
                                toolbar: {
                                    show: true
                                }
                            },
                            labels: labelsData,
                            colors: colorsData,
                        });

                        chartAlcal");
            WriteLiteral(@"des.render();
                    });
                </script>
            </div>
        </div>
    </div>

    <div class=""col-lg-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Presidentes</h5>
                <div id=""pieChartPresidentes""></div>

                <script>
                    document.addEventListener(""DOMContentLoaded"", () => {
                        var seriesData = ");
#nullable restore
#line 99 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosPresidentes.Select(m => m.TotalVotosPresidentes))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                        var labelsData = ");
#nullable restore
#line 100 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosPresidentes.Select(m => m.NombrePresidente + " " + m.ApellidoPresidente))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                        var colorsData = ");
#nullable restore
#line 101 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                                    Write(Html.Raw(Json.Serialize(listaVotosPresidentes.Select(m => m.ColorPartido))));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";


                        colorsData = colorsData.map(color => {

                            if (color === null) {
                                color = '000000';
                            }

                            if (!color.startsWith('#')) {
                                color = '#' + color;
                            }
                            return color;
                        });

                        new ApexCharts(document.querySelector(""#pieChartPresidentes""), {
                            series: seriesData,
                            chart: {
                                height: 350,
                                type: 'pie',
                                toolbar: {
                                    show: true
                                }
                            },
                            labels: labelsData,
                            colors: colorsData,
                        }).render();
                    });
         ");
            WriteLiteral(@"       </script>
            </div>
        </div>
    </div>
</div>



<div class=""card m-2 mt-4 p-3"">
    <table id=""dtVotosPorMesas"" class=""table"" style=""width:100%"">
        <thead style=""color: #78e7ff;"">
            <tr style=""background: rgb(0,0,0)"">
                <th>
                    ");
#nullable restore
#line 142 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 145 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 148 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 151 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CandidatoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 154 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalVotos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 162 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
             foreach (var mesa in VotosPorMEsas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 165 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                     if (mesa.Nombre == "Presidente" || mesa.Nombre == "Alcalde")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"background-color:#ffd800\">\r\n                            ");
#nullable restore
#line 168 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
            WriteLiteral("                        <td style=\"background-color: #ffd800\">\r\n                            ");
#nullable restore
#line 172 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 175 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 178 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.CandidatoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 181 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.TotalVotos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 183 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 187 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 191 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 194 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 197 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.CandidatoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 200 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => mesa.TotalVotos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 202 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 208 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\VotosPorMesa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            WriteLiteral(@"@section Scripts {
<script>
    function actualizarGraficoAlcaldes(datos) {
        var seriesData = datos.map(item => item.totalVotosAlcalde);
        var labelsData = datos.map(item => item.nombreAlcalde + "" "" + item.apellidoAlcalde);
        var colorsData = datos.map(item => item.colorPartido ?? '#000000');

        chartAlcaldes.updateOptions({
            series: seriesData,
            labels: labelsData,
            colors: colorsData,
        });
    }

    $(document).ready(function () {
        $('#dtVotosPorMesas').DataTable();

        $('#ddlMunicipios').change(function () {
            var municipioSeleccionado = $(this).val();
            if (municipioSeleccionado !== '') {
                $.ajax({
                    url: '/VotosPorMesa/VerAlclades',
                    method: 'GET',
                    data: { muniCodigo: municipioSeleccionado },
                    success: function (data) {
                        console.log(data, ""data"")
                       ");
            WriteLiteral(@" actualizarGraficoAlcaldes(data.listAlcaldes);
                        $(""#graficoAlcaldesContainer"").show();
                    },
                    error: function () {
                        alert('Error al obtener datos de votos de alcaldes.');
                    }
                });
            }
            else {
                $(""#graficoAlcaldesContainer"").hide();
            }
        });
    });
</script>
}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend_Sistema_Votaciones.Models.VotosPorMesasViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
