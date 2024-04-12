#pragma checksum "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f572bc9d160e09a89ae1c5051a59964b6807798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargos_Details), @"mvc.1.0.view", @"/Views/Cargos/Details.cshtml")]
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
#line 3 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f572bc9d160e09a89ae1c5051a59964b6807798", @"/Views/Cargos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Cargos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_Sistema_Votaciones.Models.CargoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
  
    ViewData["Title"] = "Cargos";
    var abrirModal = TempData["AbrirModal"];
    string serializedItem = (string)TempData["Item"];

    CargoViewModel itemModel = null;
    if (!String.IsNullOrEmpty(serializedItem))
    {
        itemModel = JsonConvert.DeserializeObject<CargoViewModel>(serializedItem);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Detalles</h1>


<div class=""card m-3"">
    <div class=""card-header text-center"">
        Información del Cargo
    </div>
    <div class=""card-body"">
        <dl class=""row"">
            <div class=""col-sm-6"">
                <dl>
                    <dt>
                        ");
#nullable restore
#line 29 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 32 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 39 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 42 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n<div class=\"mx-3\">\r\n");
            WriteLiteral("    <button data-id=\"");
#nullable restore
#line 53 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                Write(Model.Carg_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btnEditar btn btn-primary\" style=\"max-width: 100px\">\r\n        <i class=\"bi bi-pencil\"></i>\r\n        Editar\r\n    </button>\r\n    <a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 1696, "\"", 1723, 1);
#nullable restore
#line 57 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
WriteAttributeValue("", 1703, Url.Action("Index"), 1703, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Regresar</a>\r\n</div>\r\n\r\n<hr />\r\n<div class=\"card m-3\">\r\n    <div class=\"card-header text-center\">\r\n        Auditoría\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 68 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Carg_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 71 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Carg_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 74 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Carg_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 77 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Carg_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 80 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Carg_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 83 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Carg_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 86 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Carg_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 89 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Carg_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#dtCargos\').DataTable();\r\n        $(\'#modal\' + \'");
#nullable restore
#line 97 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                 Write(abrirModal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').modal(\'show\');\r\n");
#nullable restore
#line 98 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
         if (itemModel != null)
        {
            switch (abrirModal)
            {
                case "Nuevo":
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        $(\'#Carg_Id_Create\').val(\"");
#nullable restore
#line 104 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                                             Write(itemModel.Carg_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Carg_Descripcion_Create\').val(\"");
#nullable restore
#line 105 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                                                      Write(Html.Raw(itemModel.Carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    ");
#nullable restore
#line 106 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                           
                    break;
                 case "Editar":
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        $(\'#Carg_Id_Edit\').val(\"");
#nullable restore
#line 110 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                                           Write(itemModel.Carg_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                        $(\'#Carg_Descripcion_Edit\').val(\"");
#nullable restore
#line 111 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                                                    Write(Html.Raw(itemModel.Carg_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                    ");
#nullable restore
#line 112 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
                           
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
            url: `/Cargos/Edit/${id}`,
            method: ""GET"",
            success: function (cargo) {
                console.log(cargo, ""cargo"")
                $('#Carg_Id_Edit').val(cargo.carg_Id);
                $('#Carg_Descripcion_Edit').val(cargo.carg_Descripcion);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.error(""Error al cargar los datos del cargo:"", errorThrown);
            }
        });
        $('#modalEditar').modal('show');
    });

    function Eliminar(Carg_Id) {
        $(""#Carg_Id_Delete"").val(Carg_Id);
        localStorage.setItem(""#Carg_Id_Delete"", Carg_Id);
        $('#modalEliminar').modal('show');
    }
</script>
<div class=""modal fade"" id=""modalEditar"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidd");
            WriteLiteral(@"en=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 152 "C:\Users\test\OneDrive\Documentos\GitHub\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Cargos\Details.cshtml"
           Write(Html.Partial("_Edit", new Frontend_Sistema_Votaciones.Models.CargoViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Sistema_Votaciones.Models.CargoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
