#pragma checksum "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fba9ce37a08e22dea40f28190690c56ee0617b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterBlogs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterBlogs/Default.cshtml")]
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
#line 1 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\_ViewImports.cshtml"
using CoreDemo4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\_ViewImports.cshtml"
using CoreDemo4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fba9ce37a08e22dea40f28190690c56ee0617b5", @"/Views/Shared/Components/WriterBlogs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df59f691438fd8f5d800115c0cd5f074535f89f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterBlogs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogReadAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""card-body"">
    <h4 class=""card-title"">Project Status</h4>
    <div class=""table-responsive"">
        <table class=""table"">
            <thead>
                <tr>
                    <th> # </th>
                    <th> Ad </th>
                    <th> Category </th>
                    <th> Yaranma tarixi </th>
                    <th> Detaylar </th>
                </tr>
            </thead>
            <tbody>
                <tr>
");
#nullable restore
#line 19 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td> 1 </td>\r\n                        <td>  ");
#nullable restore
#line 22 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>\r\n                            <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 24 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                                                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                        Write(((DateTime)item.BlogCreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";</td>
                        <td>
                            <div class=""progress"">
                                <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </td>
");
            WriteLiteral("                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fba9ce37a08e22dea40f28190690c56ee0617b56837", async() => {
                WriteLiteral("Detaylar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                                                                                WriteLiteral(item.BlogID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Shared\Components\WriterBlogs\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591