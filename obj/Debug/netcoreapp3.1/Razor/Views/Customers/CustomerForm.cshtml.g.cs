#pragma checksum "D:\Vidly\Views\Customers\CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3bb68a8e92f05f88d8ac0a49d57c195eb339ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3bb68a8e92f05f88d8ac0a49d57c195eb339ee", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModel.NewCustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
Write(ViewData["H2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 11 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
 using (Html.BeginForm("Create", "Customers", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Customer.BirthDate, "{0:d MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Customer.MembershipTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
   Write(Html.DropDownListFor(m => m.Customer.MembershipTypeId, new SelectList(Model.MembershipTypes, "Id", "Name"), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"checkbox\">\r\n        <label>\r\n            ");
#nullable restore
#line 27 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
       Write(Html.CheckBoxFor(m => m.Customer.isSubscribeToNewsLetter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subscribe to newsletter?\r\n        </label>\r\n    </div>\r\n");
#nullable restore
#line 30 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
Write(Html.HiddenFor(m => m.Customer.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 32 "D:\Vidly\Views\Customers\CustomerForm.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModel.NewCustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
