#pragma checksum "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ea7e1266bb3053e4492320e6a55621ea165450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Details), @"mvc.1.0.view", @"/Views/Empleados/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ea7e1266bb3053e4492320e6a55621ea165450", @"/Views/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_Sistema_Votaciones.Models.EmpleadoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>EmpleadoViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_UsuarioCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_UsuarioModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_FechaModifica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Part_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Part_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Carg_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empl_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empl_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dept_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sede_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sede_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mesa_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mesa_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vota_NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vota_NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 89 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Empleados\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ea7e1266bb3053e4492320e6a55621ea16545013240", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Sistema_Votaciones.Models.EmpleadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
