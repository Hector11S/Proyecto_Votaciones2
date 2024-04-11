#pragma checksum "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd362403a962d4c00afbfe488fa1e6988472f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Municipio_Index), @"mvc.1.0.view", @"/Views/Municipio/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd362403a962d4c00afbfe488fa1e6988472f67", @"/Views/Municipio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Municipio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend_Sistema_Votaciones.Models.MunicipioViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
  
    ViewData["Title"] = "Municipios";
    var abrirModal = TempData["AbrirModal"];
    string serializedItem = (string)TempData["Item"];

    MunicipioViewModel itemModel = null;
    if (!String.IsNullOrEmpty(serializedItem))
    {
        itemModel = JsonConvert.DeserializeObject<MunicipioViewModel>(serializedItem);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"w-100 d-flex justify-content-between align-items-center p-2\" style=\"background: rgb(255,255,255); min-height: 12vh;\">\r\n    <h2>Listado de ");
#nullable restore
#line 18 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
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
    <table id=""dtMunicipios"" class=""table datatable display"" style=""width: 100%;"">
        <thead style=""color: #78e7ff;"">
            <tr style=""background: rgb(0,0,0)"">
                <th>
                    ");
#nullable restore
#line 35 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Muni_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"max-width: 300px;\">\r\n                    Acciones\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Muni_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td style=""width: 5%"">
                        <div class=""w-100"" style=""max-width: 250px"">
                            <div class=""d-flex w-100"" style=""gap: 5px;"">
                                <button data-id=""");
#nullable restore
#line 58 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                            Write(item.Muni_Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btnEditar d-flex align-items-center justify-content-around btn btn-outline-warning btn-sm flex-grow-1"" style=""max-width: 100px"">
                                    <i class=""bi bi-pencil""></i>
                                    Editar
                                </button>
                                <a class=""d-flex align-items-center justify-content-around btn btn-outline-secondary btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("href", " href=\"", 2757, "\"", 2815, 1);
#nullable restore
#line 62 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
WriteAttributeValue("", 2764, Url.Action("Details", new { id=item.Muni_Codigo }), 2764, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""bi bi-eye""></i>
                                    Detalles
                                </a>
                                <button class=""d-flex align-items-center justify-content-around btn btn-outline-danger btn-sm flex-grow-1"" style=""max-width: 100px""");
            BeginWriteAttribute("onclick", " onclick=\"", 3129, "\"", 3168, 3);
            WriteAttributeValue("", 3139, "Eliminar(\'", 3139, 10, true);
#nullable restore
#line 66 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
WriteAttributeValue("", 3149, item.Muni_Codigo, 3149, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3166, "\')", 3166, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""bi bi-trash-fill""></i>
                                    Eliminar
                                </button>
                            </div>
                        </div>
                    </td>
                </tr>
");
#nullable restore
#line 74 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#dtMunicipios\').DataTable();\r\n        $(\'#modal\' + \'");
#nullable restore
#line 86 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                 Write(abrirModal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').modal(\'show\');\r\n");
#nullable restore
#line 87 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
         if (itemModel != null)
        {
            switch (abrirModal)
            {
                case "Nuevo":
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        $(\'#Dept_Codigo_Create\').val(\"");
#nullable restore
#line 93 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                                 Write(itemModel.Dept_Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Muni_Codigo_Create\').val(\"");
#nullable restore
#line 94 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                                 Write(itemModel.Muni_Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Muni_Descripcion_Create\').val(\"");
#nullable restore
#line 95 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                                      Write(Html.Raw(itemModel.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    ");
#nullable restore
#line 96 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                           
                    break;
                 case "Editar":
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        $(\'#Dept_Codigo_Edit\').val(\"");
#nullable restore
#line 100 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                               Write(itemModel.Dept_Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Muni_Codigo_Edit\').val(\"");
#nullable restore
#line 101 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                               Write(itemModel.Muni_Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Muni_Descripcion_Edit\').val(\"");
#nullable restore
#line 102 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                                                    Write(Html.Raw(itemModel.Muni_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    ");
#nullable restore
#line 103 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
                           
                    break;
                default:
                    break;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    })
    $('#btnNuevo').click(function () {
        $('#modalNuevo').modal('show');
    });
    $('.btnEditar').click(function () {
        var id = $(this).data(""id"");
        $.ajax({
            url: `/Municipio/Edit/${id}`,
            method: ""GET"",
            success: function (municipio) {
                console.log(municipio, ""Municipio"")
                $('#Muni_Codigo_Edit').val(municipio.muni_Codigo);
                $('#Muni_Descripcion_Edit').val(municipio.muni_Descripcion);
                //$('#Dept_Codigo_Edit').val(municipio.dept_Codigo);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.error(""Error al cargar los datos del Municipio:"", errorThrown);
            }
        });
        $('#modalEditar').modal('show');
    });

    function Eliminar(Dept_Codigo) {
        $(""#Muni_Codigo_Delete"").val(Dept_Codigo);
        localStorage.setItem(""#Muni_Codigo_Delete"", Dept_Codigo);
        $('#modalEliminar').modal('sh");
            WriteLiteral(@"ow');
    }
</script>

<div class=""modal fade"" id=""modalEditar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 145 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
           Write(Html.Partial("_Edit", new Frontend_Sistema_Votaciones.Models.MunicipioViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
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
#nullable restore
#line 158 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
           Write(Html.Partial("_Create", new Frontend_Sistema_Votaciones.Models.MunicipioViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
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
#nullable restore
#line 172 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Municipio\Index.cshtml"
           Write(Html.Partial("_Delete", new Frontend_Sistema_Votaciones.Models.MunicipioViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend_Sistema_Votaciones.Models.MunicipioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
