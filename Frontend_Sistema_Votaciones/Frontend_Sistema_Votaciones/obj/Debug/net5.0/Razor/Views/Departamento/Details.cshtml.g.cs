#pragma checksum "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c6c939954b21484eccf27bd273135b3bf61eba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamento_Details), @"mvc.1.0.view", @"/Views/Departamento/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c6c939954b21484eccf27bd273135b3bf61eba", @"/Views/Departamento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_Sistema_Votaciones.Models.DepartamentoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Detalles</h1>


<div class=""card m-3"">
    <div class=""card-header text-center"">
        Información del Departamento
    </div>
    <div class=""card-body"">
        <dl class=""row"">
            <div class=""col-sm-6"">
                <dl>
                    <dt>
                        ");
#nullable restore
#line 20 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 23 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
#nullable restore
#line 30 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Dept_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
#nullable restore
#line 33 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Dept_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n<div class=\"mx-3\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1181, "\"", 1239, 1);
#nullable restore
#line 43 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
WriteAttributeValue("", 1188, Url.Action("Edit", new { id = Model.Dept_Codigo }), 1188, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n    <a class=\"btn btn-secondary\"");
            BeginWriteAttribute("href", " href=\"", 1285, "\"", 1312, 1);
#nullable restore
#line 44 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
WriteAttributeValue("", 1292, Url.Action("Index"), 1292, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Regresar</a>\r\n</div>\r\n\r\n<hr />\r\n<div class=\"card m-3\">\r\n    <div class=\"card-header text-center\">\r\n        Auditoría\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 58 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayFor(model => model.Dept_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 61 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 64 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayFor(model => model.Dept_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 67 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 70 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayFor(model => model.Dept_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 73 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Dept_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 76 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Departamento\Details.cshtml"
           Write(Html.DisplayFor(model => model.Dept_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Sistema_Votaciones.Models.DepartamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
