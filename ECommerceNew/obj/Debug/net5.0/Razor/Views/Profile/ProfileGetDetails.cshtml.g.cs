#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde155502093c5c695ea87e4eb2bbf23ed330d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ProfileGetDetails), @"mvc.1.0.view", @"/Views/Profile/ProfileGetDetails.cshtml")]
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
#line 1 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde155502093c5c695ea87e4eb2bbf23ed330d88", @"/Views/Profile/ProfileGetDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_ProfileGetDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.EntityFramework.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
  
    ViewData["Title"] = "ProfileGetDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"shopping-cart spad\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"cart__total\">\r\n");
#nullable restore
#line 12 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                     using (Html.BeginForm("ProfileGetDetails", "Profile", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.Label("Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n");
#nullable restore
#line 18 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.Label("Mail Adresi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.UserMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserMail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n");
#nullable restore
#line 22 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.Label("Telefon Numarası"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.UserNumber, new { @class = "form-control", @type = "number" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserNumber, null, new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n");
#nullable restore
#line 26 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.Label("Şifre"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.TextBoxFor(x => x.UserPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n");
            WriteLiteral("                        <button class=\"primary-btn\">Güncelle</button>\r\n");
#nullable restore
#line 32 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\ProfileGetDetails.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.EntityFramework.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
