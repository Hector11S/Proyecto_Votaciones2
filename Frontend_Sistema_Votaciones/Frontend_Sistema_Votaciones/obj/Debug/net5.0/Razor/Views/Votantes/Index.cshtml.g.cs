#pragma checksum "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96576cfa658ae26691a936f22e31928055f00f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Votantes_Index), @"mvc.1.0.view", @"/Views/Votantes/Index.cshtml")]
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
#line 1 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\_ViewImports.cshtml"
using Frontend_Sistema_Votaciones.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96576cfa658ae26691a936f22e31928055f00f3", @"/Views/Votantes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Votantes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend_Sistema_Votaciones.Models.VotanteViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 40px; max-width: 150px; min-width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnNuevo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 40px; max-width: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
  
    ViewData["Title"] = "Votantes";
    var abrirModal = TempData["AbrirModal"];
    string serializedItem = (string)TempData["Item"];
    DepartamentoViewModel departamento = null;
    if (!String.IsNullOrEmpty(serializedItem))
    {
        departamento = JsonConvert.DeserializeObject<DepartamentoViewModel>(serializedItem);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"w-100 d-flex justify-content-between align-items-center p-2\" style=\"background: rgb(255,255,255); min-height: 12vh;\">\r\n    <h2>Listado de ");
#nullable restore
#line 18 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96576cfa658ae26691a936f22e31928055f00f37896", async() => {
                WriteLiteral("\r\n        <i class=\"bi bi-house-door-fill\"></i>\r\n        Inicio\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</header>\r\n<div class=\"card m-2 mt-4 p-3\" style=\"overflow-x: auto\">\r\n    <header");
            BeginWriteAttribute("class", " class=\"", 890, "\"", 898, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96576cfa658ae26691a936f22e31928055f00f39449", async() => {
                WriteLiteral("\r\n            <i class=\"bi bi-plus\"></i>\r\n            Nuevo\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </header>\r\n    <table id=\"dtVotante\" class=\"table datatable display mt-4\" style=\"width: 100%;\">\r\n        <thead style=\"color: #78e7ff;\">\r\n            <tr style=\"background: rgb(0,0,0)\">\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Vota_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Vota_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Vota_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Vota_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Vota_YaVoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 50 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Muni_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n  \r\n                <th>\r\n                    ");
#nullable restore
#line 57 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Esta_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 60 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MePS_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 63 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Mesa_Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 66 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Sede_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vota_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vota_Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vota_Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vota_DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vota_YaVoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Muni_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 97 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Esta_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MePS_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mesa_Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sede_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
                <td style=""width: 5%"">
                    <div class=""w-100"" style=""max-width: 250px"">
                        <div class=""d-flex w-100"" style=""gap: 5px;"">
                            <a class=""d-flex align-items-center justify-content-around btn btn-outline-warning btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("href", " href=\"", 4354, "\"", 4405, 1);
#nullable restore
#line 111 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
WriteAttributeValue("", 4361, Url.Action("Edit", new { id=item.Vota_Id }), 4361, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""bi bi-pencil""></i>
                                Editar
                            </a>
                            <a class=""d-flex align-items-center justify-content-around btn btn-outline-secondary btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("href", " href=\"", 4702, "\"", 4756, 1);
#nullable restore
#line 115 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
WriteAttributeValue("", 4709, Url.Action("Details", new { id=item.Vota_Id }), 4709, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""bi bi-eye""></i>
                                Detalles
                            </a>
                            <button class=""d-flex align-items-center justify-content-around btn btn-outline-danger btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("onclick", " onclick=\"", 5054, "\"", 5089, 3);
            WriteAttributeValue("", 5064, "Eliminar(\'", 5064, 10, true);
#nullable restore
#line 119 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
WriteAttributeValue("", 5074, item.Vota_Id, 5074, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5087, "\')", 5087, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"bi bi-trash-fill\"></i>\r\n                                Fallecida\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 127 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#dtVotante\').DataTable();\r\n            $(\'#modal\' + \'");
#nullable restore
#line 135 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                     Write(abrirModal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').modal(\'show\');\r\n");
#nullable restore
#line 136 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
             if (departamento != null)
            {
                switch (abrirModal)
                {
                    case "Nuevo":
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            $(\'#Dept_Codigo_Create\').val(\"");
#nullable restore
#line 142 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                     Write(departamento.Dept_Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                            $(\'#Dept_Descripcion_Create\').val(\"");
#nullable restore
#line 143 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                          Write(Html.Raw(departamento.Dept_Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                        ");
#nullable restore
#line 144 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                               
                        break;
                     case "Editar":
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            $(\'#Dept_Codigo_Edit\').val(\"");
#nullable restore
#line 148 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                   Write(departamento.Dept_Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                            $(\'#Dept_Descripcion_Edit\').val(\"");
#nullable restore
#line 149 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                        Write(Html.Raw(departamento.Dept_Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                        ");
#nullable restore
#line 150 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                               
                        break;
                    default:
                        break;
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("$(\'#modal\' + \'");
#nullable restore
#line 155 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                      Write(abrirModal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').modal(\'show\');\r\n");
#nullable restore
#line 156 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
             if (departamento != null)
            {
                switch (abrirModal)
                {
                    case "Nuevo":
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            $(\'#Dept_Codigo_Create\').val(\"");
#nullable restore
#line 162 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                     Write(departamento.Dept_Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                            $(\'#Dept_Descripcion_Create\').val(\"");
#nullable restore
#line 163 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                          Write(Html.Raw(departamento.Dept_Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                        ");
#nullable restore
#line 164 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                               
                        break;
                     case "Editar":
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            $(\'#Dept_Codigo_Edit\').val(\"");
#nullable restore
#line 168 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                   Write(departamento.Dept_Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                            $(\'#Dept_Descripcion_Edit\').val(\"");
#nullable restore
#line 169 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                                                        Write(Html.Raw(departamento.Dept_Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                        ");
#nullable restore
#line 170 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
                               
                        break;
                    default:
                        break;
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        });\r\n        function Eliminar(Vota_Id) {\r\n            $(\"#inputHidden\").val(Vota_Id);\r\n            localStorage.setItem(\"inputHidden\", Vota_Id);\r\n            $(\'#modalEliminar\').modal(\'show\');\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""modal fade"" id=""modalEliminar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 191 "C:\Users\test\OneDrive\Escritorio\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Votantes\Index.cshtml"
           Write(Html.Partial("_Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend_Sistema_Votaciones.Models.VotanteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591