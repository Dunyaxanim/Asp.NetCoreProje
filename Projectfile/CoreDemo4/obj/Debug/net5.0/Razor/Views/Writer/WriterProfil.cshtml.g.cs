#pragma checksum "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a2e3c02a7b6f3288315f266d9d989eac5e5c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterProfil), @"mvc.1.0.view", @"/Views/Writer/WriterProfil.cshtml")]
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
#line 1 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a2e3c02a7b6f3288315f266d9d989eac5e5c48", @"/Views/Writer/WriterProfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df59f691438fd8f5d800115c0cd5f074535f89f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterProfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
  
    ViewData["Title"] = "WriterProfil";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Yazar haqqında </th>
                               
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 23 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27a2e3c02a7b6f3288315f266d9d989eac5e5c485343", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 905, "~/CoreBlogTema/assets/images/faces/", 905, 35, true);
#nullable restore
#line 27 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
AddHtmlAttributeValue("", 940, item.WriterImage, 940, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 27 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
                                                                                                                            Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        <h3 class=\"badge badge-gradient-success\">");
#nullable restore
#line 31 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
                                                                            Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <h4 class=\"badge badge-gradient-success\">");
#nullable restore
#line 32 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
                                                                            Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\Writer\WriterProfil.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591