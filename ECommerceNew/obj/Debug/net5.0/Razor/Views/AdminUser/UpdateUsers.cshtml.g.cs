#pragma checksum "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ab6d463ac9ab7c375a6de93d7d5fdb05a601db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUser_UpdateUsers), @"mvc.1.0.view", @"/Views/AdminUser/UpdateUsers.cshtml")]
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
#line 1 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ab6d463ac9ab7c375a6de93d7d5fdb05a601db", @"/Views/AdminUser/UpdateUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUser_UpdateUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.EntityFramework.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
  
    ViewData["Title"] = "UpdateUsers";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Kullanıcı Güncelleme Formu</h4>\r\n");
#nullable restore
#line 11 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
             using (Html.BeginForm("UpdateUsers", "AdminUser", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.HiddenFor(x => x.UserID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label for=\"exampleInputName1\">Kullanıcı Adı</label>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.TextBoxFor(x => x.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.ValidationMessageFor(x => x.UserName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <label for=\"exampleInputName1\">Mail Adresi</label>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.TextBoxFor(x => x.UserMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.ValidationMessageFor(x => x.UserMail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    \r\n                    <label for=\"exampleInputName1\">Şifresi</label>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.TextBoxFor(x => x.UserPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.ValidationMessageFor(x => x.UserPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    \r\n                    <label for=\"exampleInputName1\">Telefon Numarası</label>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.TextBoxFor(x => x.UserNumber, new { @class = "form-control",@type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
               Write(Html.ValidationMessageFor(x => x.UserNumber, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    \r\n                    <br />\r\n\r\n                </div>\r\n");
            WriteLiteral("                <button class=\"btn btn-primary mr-2\">Güncelle</button>\r\n                <button class=\"btn btn-light\">İptal</button>\r\n");
#nullable restore
#line 41 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminUser\UpdateUsers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
