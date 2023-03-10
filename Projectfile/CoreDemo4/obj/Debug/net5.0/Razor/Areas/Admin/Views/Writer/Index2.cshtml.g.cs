#pragma checksum "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\Writer\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b0f69bc9219820ea7a4c805061983fa3dd714f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index2), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b0f69bc9219820ea7a4c805061983fa3dd714f", @"/Areas/Admin/Views/Writer/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114ba282a3e86d9fb46887e1650e0dbae9be560b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Writer_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dunya - PC\source\repos\AspNetCoreProject\ProjectAspNet\CoreDemo4\CoreDemo4\Areas\Admin\Views\Writer\Index2.cshtml"
  
    ViewData["Title"] = "Index2";
    Layout = "~/Areas/Admin/Views/Shared/_Admin2Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index2</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar listi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar g??tir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar ??lave et</button>
<button type=""button"" id=""btndeletwriter"" class=""btn btn-outline-danger"">Yazar sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar?? d??yi??</button>
<div id=""writerlist"">
    yazarlar g??l??c??k
</div>

<br />

<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID d??y??ri daxil edin"" />
</div>

<br />
<div>
    <input type=""text"" id=""textwriterid"" placeholder=""Yazar ID"" class=""form-control"" />
    <input type=""text"" id=""textwritername"" placeholder=""Yazar adi "" class=""form-control"" />
</div>

<br />

<div>
    <input type=""text"" id=""textid"" placeholder=""Yazar ID d??y??ri daxil edin"" />
</div>

<br />
<input type=""text"" id=""textid1"" placeholde");
            WriteLiteral("r=\"Yazar ID d??y??ri daxil edin\" class=\"form-control\" />\r\n<input type=\"text\" id=\"textwriterName1\" placeholder=\"Yazar adi d??y??ri daxil edin\" class=\"form-control\" />\r\n<br />\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func)
                    console.log(w);
                    let tablehtml = ""<table class=table table-borderd><tr><th>Yazar ID</th><th>Yazar adi</th></tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += '<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>'
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            console.log(id);
            $.ajax({
                contentType: ""application/json"",
                d");
                WriteLiteral(@"ataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func)
                    console.log(w);

                    let getvalue = '<table class = table table-borderd><tr><th> Yazar ID </th> <th> Yazar Adi</th></tr> <tr><td>$(w.Id)</td></tr><tr><td>${w.Name}</td><th></table>';
                    $(""#writerget"").html(getvalue);

                }
            })
        })

        $(""#btnaddwriter"").click(function () {
            let writer = {
                Id: $(""#textwriterid"").val(),
                Name: $(""#textwritername"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func)
                    alert(""Yazar ");
                WriteLiteral(@"elave etmek"");
                }
            })
        })

        $(""#btndeletwriter"").click(x => {
            let id = $(""#textid"").val();
            $.ajax({
                url: ""/Admin/Writer/DeletWriter/"",
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silindi"");
                }
            })
        }
        );


        $(""#btnupdatewriter"").click(function () {
            let writer = {
                Id: $(""#textid1"").val(),
                Name: $(""#textwriterName1"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",

                data: writer,

                success: function (func) {
                    alert(""Yazar d??yi??dirili"");
                }
            });
        });
    </script>
");
            }
            );
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
