#pragma checksum "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f150e02a504a2389d1bf948d48ca6e07642e3b26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f150e02a504a2389d1bf948d48ca6e07642e3b26", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend_Sistema_Votaciones.Models.EmpleadoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"w-100 d-flex justify-content-between align-items-center p-2\" style=\"background: rgb(255,255,255); min-height: 12vh;\">\r\n    <h2>Listado de ");
#nullable restore
#line 9 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <button href=""~/"" class=""btn btn-primary"" style=""max-height: 40px; max-width: 150px; min-width: 100px"">
        <i class=""bi bi-house-door-fill""></i>
        Inicio
    </button>
</header>
<div class=""card m-2 mt-4 p-3"" style=""overflow-x: auto"">
    <header class=""mb-4"">
        <button id=""btnNuevo"" class=""btn btn-outline-primary"" style=""max-height: 40px; max-width: 150px;"" data-toggle=""modal"" data-target=""#modal"">
            <i class=""bi bi-plus""></i>
            Nuevo
        </button>
    </header>
    <table id=""dtCargos"" class=""table datatable display"" style=""width: 100%;"">
        <thead style=""color: #78e7ff;"">
            <tr style=""background: rgb(0,0,0)"">
                <th>
                    ");
#nullable restore
#line 26 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Part_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Empl_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Sede_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Mesa_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Acciones</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 47 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Part_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Empl_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sede_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mesa_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"width: 5%\">\r\n                    <div class=\"w-100\" style=\"max-width: 250px\">\r\n                        <div class=\"d-flex w-100\" style=\"gap: 5px;\">\r\n                            <button data-id=\"");
#nullable restore
#line 72 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
                                        Write(item.Mesa_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btnEditar d-flex align-items-center justify-content-around btn btn-outline-warning btn-sm flex-grow-1"" style=""max-width: 100px"">
                                <i class=""bi bi-pencil""></i>
                                Editar
                            </button>
                            <a class=""d-flex align-items-center justify-content-around btn btn-outline-secondary btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("href", " href=\"", 3210, "\"", 3265, 1);
#nullable restore
#line 76 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
WriteAttributeValue("", 3217, Url.Action(" Details", new { id=item.Mesa_Id }), 3217, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""bi bi-eye""></i>
                                Detalles
                            </a>
                            <button class=""d-flex align-items-center justify-content-around btn btn-outline-danger btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("onclick", " onclick=\"", 3563, "\"", 3598, 3);
            WriteAttributeValue("", 3573, "Eliminar(\'", 3573, 10, true);
#nullable restore
#line 80 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
WriteAttributeValue("", 3583, item.Mesa_Id, 3583, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3596, "\')", 3596, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"bi bi-trash-fill\"></i>\r\n                                Eliminar\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
        $(document).ready(function () {
            $('#dtMesas').DataTable();
        });

        $('#btnNuevo').click(function () {
            $('#modalNuevo').modal('show');
        });

        $('#btnEditar').click(function () {
            $('#modalEditar').modal('show');
        });

        $('#btnNuevo').click(function () {
            $('#modalEliminar').modal('show');
        });
</script>
");
            }
            );
            WriteLiteral(@"
<div class=""modal fade"" id=""modalEditar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
");
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalNuevo"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
");
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""modalEliminar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend_Sistema_Votaciones.Models.EmpleadoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
