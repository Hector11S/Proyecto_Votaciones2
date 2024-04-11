#pragma checksum "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69bb5656b7b5829bd3242ffa081e749e172e0e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Create), @"mvc.1.0.view", @"/Views/Roles/Create.cshtml")]
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
#nullable restore
#line 2 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69bb5656b7b5829bd3242ffa081e749e172e0e8b", @"/Views/Roles/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d02db7aed26e09385f29e2d4baf3f8592fe7359", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_Sistema_Votaciones.Models.RolesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 280px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
  
    var Rol_Id = Model != null ? Model.Rol_Id : 0;
    var roles = ViewBag.Roles;
    var pantallas = ViewBag.Pantallas;
    var esquemas = ViewBag.Esquemas;
    var pantallasPorRoles = ViewBag.PantallasPorRoles;
    ViewData["Title"] = "Roles";
    var abrirModal = TempData["AbrirModal"];
    string serializedItem = (string)TempData["Item"];

    RolesViewModel rol = null;
    if (!String.IsNullOrEmpty(serializedItem))
    {
        rol = JsonConvert.DeserializeObject<RolesViewModel>(serializedItem);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""w-100 d-flex justify-content-between align-items-center p-2"" style=""background: rgb(255,255,255); min-height: 12vh;"">
    <h2>Pantallas por rol</h2>
    <button href=""~/"" class=""btn btn-primary"" style=""max-height: 40px; max-width: 150px; min-width: 100px"">
        <i class=""bi bi-house-door-fill""></i>
        Inicio
    </button>
</header>
<div class=""card m-2 mt-4 p-3"" style=""overflow-x: auto"">
    <div class=""d-flex align-items-center flex-column"" style=""min-height: 50vh; justify-content: start;"">
        <div style=""min-width: 280px"">
            <label style=""color: #3dbdd9"">Rol</label>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bb5656b7b5829bd3242ffa081e749e172e0e8b5711", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bb5656b7b5829bd3242ffa081e749e172e0e8b5987", async() => {
                    WriteLiteral("--Rol--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                 if (roles != null)
                {
                    foreach (var item in roles)
                    {
                        if (item.Rol_Id == Rol_Id)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bb5656b7b5829bd3242ffa081e749e172e0e8b7471", async() => {
#nullable restore
#line 39 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                                             Write(item.Rol_Descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                               WriteLiteral(item.Rol_Id);

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
#line 40 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bb5656b7b5829bd3242ffa081e749e172e0e8b10115", async() => {
#nullable restore
#line 43 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                                    Write(item.Rol_Descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                               WriteLiteral(item.Rol_Id);

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
#line 44 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 31 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rol_Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""outer"">
            <ul id=""ul"">
                <li>
                    <span class=""caret""><label>Sistema electoral</label></span><input id=""checkboxSistemaElectoral"" type=""checkbox"" style=""margin-left: 10px;"">
                    <ul class=""nested"" style=""border-left: 3px dashed gray; left: -26px; position: relative; top: -6px; padding-left: 0; margin-left: 32px; "">
");
#nullable restore
#line 54 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                         if (esquemas != null && pantallas != null)
                        {
                            foreach (var esquema in esquemas)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li style=""position: relative; min-height: 30px;background: #fff; border-bottom: 3px dashed gray;"">
                                    <div style="" position: absolute; top: 50%; min-width: 100%; z-index: 1; background: #fff; left: 15px;"">
                                        <span class=""caret""><label>");
#nullable restore
#line 60 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                                              Write(esquema);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></span><input");
            BeginWriteAttribute("id", " id=\"", 2914, "\"", 2927, 1);
#nullable restore
#line 60 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
WriteAttributeValue("", 2919, esquema, 2919, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" style=\"margin-left: 10px;\">\r\n                                        <ul class=\"nested\" style=\"left: -26px; position: relative; top: -6px; border-left: 3px dashed gray; padding-left: 0; margin-left: 32px;\">\r\n");
#nullable restore
#line 62 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                             foreach (var pantalla in pantallas)
                                            {
                                                if (pantalla.Pant_Esquema == esquema)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <li style=""position: relative; min-height: 30px;background: #fff; border-bottom: 3px dashed gray;"">
                                                        <div style="" position: absolute; top: 50%; min-width: 300px; z-index: 1; background: #fff; left: 15px;"">
                                                            <input");
            BeginWriteAttribute("id", " id=\"", 3801, "\"", 3823, 1);
#nullable restore
#line 68 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
WriteAttributeValue("", 3806, pantalla.Pant_Id, 3806, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" />\r\n                                                            <label");
            BeginWriteAttribute("for", " for=\"", 3911, "\"", 3934, 1);
#nullable restore
#line 69 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
WriteAttributeValue("", 3917, pantalla.Pant_Id, 3917, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                                                                      Write(pantalla.Pant_Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                        </div>\r\n                                                    </li>\r\n");
#nullable restore
#line 72 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 77 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"<script>
    var toggler = document.getElementsByClassName(""caret"");
    var i;

    for (i = 0; i < toggler.length; i++) {
        toggler[i].addEventListener(""click"", function () {
            this.parentElement.querySelector("".nested"").classList.toggle(""active"");
            this.classList.toggle(""caret-down"");
            const ulNested = this.parentElement.querySelector("".nested"");
            const { height } = ulNested.getBoundingClientRect();
            console.log(ulNested, 'ulNested');
            ulNested.closest(""li"").style.marginBottom = `${height}px`;
        });
    }

    const pantallasPorRolesJSON = JSON.parse('");
#nullable restore
#line 130 "C:\repositorio\Proyecto_Votaciones2\Frontend_Sistema_Votaciones\Frontend_Sistema_Votaciones\Views\Roles\Create.cshtml"
                                         Write(Html.Raw(pantallasPorRoles));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
    console.log(pantallasPorRolesJSON);

    let dropdownChangedByUser = true;
    //$('#ParoTreeView').jstree({
    //    ""core"": {
    //        ""themes"": {
    //            ""variant"": ""large""
    //        }
    //    },
    //    ""checkbox"": {
    //        ""keep_selected_style"": false
    //    },
    //    ""plugins"": [""checkbox""]
    //}).on('changed.jstree', function (e, data) {
    //    if (dropdownChangedByUser) {
    //        dropdownChangedByUser = false;
    //        return;
    //    }
    //    console.log(data.node.id, ""data.node.id"")
    //    if (/^\d+$/.test(ddlRoles.value)) {
    //        if (/^\d+$/.test(data.node.id)) {
    //            let method = ""DELETE"";
    //            if (data.action === ""select_node"") {
    //                method = ""GET"";
    //            }
    //            $.ajax({
    //                url: `/Roles/${method === ""GET"" ? ""Create"" : ""Delete""}PantallasPorRoles?Rol_Id=${ddlRoles.value}&Pant_Id=${data.node.id}`,
    //      ");
            WriteLiteral(@"          method,
    //                success: function (response) {
    //                    console.log(response, ""PantallasPorRoles/Create"");
    //                    if (response.result === true) {
    //                        iziToast.success({
    //                            title: 'Exito',
    //                            message: response.message,
    //                            position: 'topRight',
    //                            transitionIn: 'flipInX',
    //                            transitionOut: 'flipOutX'
    //                        });
    //                    } else {
    //                        iziToast.error({
    //                            title: 'Error',
    //                            message: response.message,
    //                            position: 'topRight',
    //                            transitionIn: 'flipInX',
    //                            transitionOut: 'flipOutX'
    //                        });
    //                    }");
            WriteLiteral(@"
    //                },
    //                error: function (jqXHR, textStatus, errorThrown) {
    //                    console.error(`Error al asignar las pantallas al rol`, errorThrown);
    //                }
    //            });
    //        } else {
    //            alert(""AAAAAAAAA"");
    //        }
    //    } else {
    //        var selectedNodes = data.selected;

    //        $.each(selectedNodes, function (index, nodeId) {
    //            $('#ParoTreeView').jstree('uncheck_node', nodeId);
    //        });
    //        if (data.action === ""select_node"") {
    //            iziToast.warning({
    //                title: 'Seleccione un rol',
    //                message: ""Por favor seleccione un rol"",
    //                position: 'topRight',
    //                transitionIn: 'flipInX',
    //                transitionOut: 'flipOutX'
    //            });
    //        }
    //    }
    //})
    const ddlRoles = document.getElementById(""Rol_Id"");
    ddlR");
            WriteLiteral(@"oles.addEventListener(""change"", () => {
        dropdownChangedByUser = true;
        const pantallasToCheck = pantallasPorRolesJSON.filter(item => item.Rol_Id === parseInt(ddlRoles.value));
        console.log(pantallasToCheck);
        pantallasToCheck.forEach(pantalla => {
            const nodeId = pantalla.Pant_Id.toString();
            $('#ParoTreeView').jstree('check_node', nodeId);
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_Sistema_Votaciones.Models.RolesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
