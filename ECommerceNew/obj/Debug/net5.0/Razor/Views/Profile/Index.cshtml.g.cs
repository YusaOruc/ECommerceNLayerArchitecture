#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f1960c82cadcbb3cc4d675f7bba8524843a2b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f1960c82cadcbb3cc4d675f7bba8524843a2b3", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>Profilim</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/HomeProduct/Index/"">Ana Sayfa</a>
                        <span>Profilim</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<section class=""shopping-cart spad"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-8"">
");
#nullable restore
#line 31 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"cart__total\">\r\n                        <h6 style=\"text-align:center;\">Profil Bilgilerim</h6>\r\n                        <hr />\r\n                        <a>Kullanıcı Adım: ");
#nullable restore
#line 36 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
                                      Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <hr />\r\n                        <a>Mail Adresim : ");
#nullable restore
#line 38 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
                                     Write(item.UserMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <hr />\r\n                        <a>Telefon Numaram : ");
#nullable restore
#line 40 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
                                        Write(item.UserNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <hr />\r\n                        <a>Şifrem : ********** </a>\r\n\r\n\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"cart__total\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1531, "\"", 1577, 2);
            WriteAttributeValue("", 1538, "/Profile/ProfileGetDetails/", 1538, 27, true);
#nullable restore
#line 49 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1565, item.UserID, 1565, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"primary-btn\">Profil Bilgilerimi Güncelle</a>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                <a style=\"float:right;margin-right:10px;margin-top:10px;\" href=\"/MyOrders/Index/\" class=\"btn btn-info\">Siparişlerim</a>\r\n                <br />\r\n                ");
#nullable restore
#line 60 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Profile\Index.cshtml"
           Write(await Component.InvokeAsync("Adress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
