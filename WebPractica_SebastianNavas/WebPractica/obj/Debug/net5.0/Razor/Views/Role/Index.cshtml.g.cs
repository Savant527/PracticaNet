#pragma checksum "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc72eaceb1b6d52fe3bc7f7120c3b4fd81b8db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
#line 1 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\_ViewImports.cshtml"
using WebPractica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\_ViewImports.cshtml"
using WebPractica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc72eaceb1b6d52fe3bc7f7120c3b4fd81b8db5", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e75e1ade7019490a284be19410a6c3fc2971c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper"">
    <div class=""content-wrapper"">
        <h1 class=""text-center"">Lista de Usuarios</h1>
        <hr />
        <div class=""container"">
            <div class=""row"">
                <div class=""mx-auto"">
                    <div class=""col-lg-12"">
");
#nullable restore
#line 11 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                         if (Model.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>No hay usuarios</p> ");
#nullable restore
#line 13 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                                                   }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class=""table table-striped table-bordered"">
                                <thead class=""bg-dark text-white"">
                                    <tr>
                                        <th>Usuarios</th>
                                        <th>Roles del usuario</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 24 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                                     foreach (var u in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 27 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                                           Write(u.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc72eaceb1b6d52fe3bc7f7120c3b4fd81b8db56198", async() => {
                WriteLiteral("Ver Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                                                                                      WriteLiteral(u.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 32 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 35 "C:\PROYECTO\JHON_NAVAS\Practica\WebPractica_SebastianNavas\WebPractica\Views\Role\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
