#pragma checksum "D:\Vidly\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "413d7ac97dfc5a550247a6e403a1ebbed6f04ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "D:\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413d7ac97dfc5a550247a6e403a1ebbed6f04ddd", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vidly.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Customers List</h2>\r\n\r\n<input class=\"btn btn-primary mb-3\" \r\n       type=\"button\" \r\n       value=\"New Customer\"");
            BeginWriteAttribute("onclick", " \r\n       onclick=\"", 288, "\"", 354, 3);
            WriteAttributeValue("", 307, "location.href=\'", 307, 15, true);
#nullable restore
#line 12 "D:\Vidly\Views\Customers\Index.cshtml"
WriteAttributeValue("", 322, Url.Action("New", "Customers"), 322, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 353, "\'", 353, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />

<table id=""customers"" class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Customer</th>
            <th>Membership Type</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {

            var table = $(""#customers"").DataTable({

                ajax: {
                    url: ""/api/customers"",
                    dataSrc: """"
                },

                columns: [
                    {
                        data: ""name"",
                        render: function (data, type, customer) {
                            return ""<a href='/customers/edit/"" + customer.id + ""'>"" + customer.name + ""</a>"";
                        }
                    },
                    {
                        data: ""membershipType.name""
                    },
                    {
                        data: ""id"",
                        render: function (data) {
                            return ""<button class = 'btn btn-link js-delete' data-customer-id="" + data + "">Delete</button>"";
                        }
                    }
                ]
            });

            $(""#customers"").on(""click"", ");
                WriteLiteral(@""".js-delete"", function () {
                var button = $(this);
                bootbox.confirm(""Delete this customer ?"", function (result) {
                    if (result) {
                        $.ajax({
                            url: ""/api/customers/"" + button.attr(""data-customer-id""),
                            method: ""DELETE"",
                            success: function () {
                                table.row(button.parents(""tr"")).remove().draw();
                            }
                        })
                    }
                })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vidly.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
