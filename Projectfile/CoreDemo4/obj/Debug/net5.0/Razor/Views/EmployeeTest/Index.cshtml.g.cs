#pragma checksum "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9f6b31797d68399e15e6c250f0eafa45dec225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#line 3 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\_ViewImports.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
using CoreDemo4.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9f6b31797d68399e15e6c250f0eafa45dec225", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df59f691438fd8f5d800115c0cd5f074535f89f2", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Admin2Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df9f6b31797d68399e15e6c250f0eafa45dec2254529", async() => {
                WriteLiteral(" Əlavə et ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>>\r\n        <th>Ad Soyad</th>\r\n        <th>Funksiyalar</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 19 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 20 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 510, "\"", 554, 2);
            WriteAttributeValue("", 517, "/EmployeeTest/UpdateEmployee/", 517, 29, true);
#nullable restore
#line 21 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 546, item.ID, 546, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   class=\"btn btn-outline-danger\">Dəyiş</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 623, "\"", 667, 2);
            WriteAttributeValue("", 630, "/EmployeeTest/DeleteEmployee/", 630, 29, true);
#nullable restore
#line 22 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 659, item.ID, 659, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   class=\"btn btn-outline-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Dunya - PC\source\repos\CoreDemo4\ProjectAspNetCore\CoreDemo4\Views\EmployeeTest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591