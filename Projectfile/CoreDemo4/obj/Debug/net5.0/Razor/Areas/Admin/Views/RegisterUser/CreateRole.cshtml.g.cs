#pragma checksum "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1ba3fa8e1cbcc3bc68743d7849a5496531a773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_RegisterUser_CreateRole), @"mvc.1.0.view", @"/Areas/Admin/Views/RegisterUser/CreateRole.cshtml")]
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
#line 1 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo4.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1ba3fa8e1cbcc3bc68743d7849a5496531a773", @"/Areas/Admin/Views/RegisterUser/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114ba282a3e86d9fb46887e1650e0dbae9be560b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_RegisterUser_CreateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.AppRole>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml"
  
    ViewData["Title"] = "CreateRole";
    Layout = "~/Areas/Admin/Views/Shared/_Admin2Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Yeni Blog</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 13 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml"
                 using (Html.BeginForm("CreateRole", "RegisterUser", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div cl ass=\"form-row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label>Rol ad?? daxil edin</label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml"
                       Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Daxil et</button>\r\n");
#nullable restore
#line 32 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\RegisterUser\CreateRole.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.AppRole> Html { get; private set; }
    }
}
#pragma warning restore 1591
