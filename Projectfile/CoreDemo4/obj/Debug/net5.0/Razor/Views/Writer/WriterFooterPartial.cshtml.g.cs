#pragma checksum "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\Writer\WriterFooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf6625d7261af2097e4b783220f0ff9d255da2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterFooterPartial), @"mvc.1.0.view", @"/Views/Writer/WriterFooterPartial.cshtml")]
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
#line 1 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\_ViewImports.cshtml"
using CoreDemo4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\_ViewImports.cshtml"
using CoreDemo4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\_ViewImports.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\_ViewImports.cshtml"
using CoreDemo4.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6625d7261af2097e4b783220f0ff9d255da2b0", @"/Views/Writer/WriterFooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c649d7c15583dbf58994cc1cb91a43cedf7bdf35", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterFooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer class=\"footer\">\r\n    <div class=\"container-fluid clearfix\">\r\n        <span class=\"text-muted d-block text-center text-sm-left d-sm-inline-block\">Copyright ?? T??m haklar?? sakl??d??r ");
#nullable restore
#line 4 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Views\Writer\WriterFooterPartial.cshtml"
                                                                                                                Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"float-none float-sm-right d-block mt-1 mt-sm-0 text-center\"> Yazar Paneli <a href=\"https://www.bootstrapdash.com/bootstrap-admin-template/\" target=\"_blank\">Core 5.0 Proje </a></span>\r\n    </div>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
