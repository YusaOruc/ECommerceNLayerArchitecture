#pragma checksum "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa707abcecc2a225a55aec1fa529363c413fc1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminAdmin_UpdateAdmin), @"mvc.1.0.view", @"/Views/AdminAdmin/UpdateAdmin.cshtml")]
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
#line 1 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\_ViewImports.cshtml"
using ECommerceNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa707abcecc2a225a55aec1fa529363c413fc1b", @"/Views/AdminAdmin/UpdateAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminAdmin_UpdateAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.EntityFramework.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
  
    ViewData["Title"] = "UpdateAdmin";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Admin Güncelleme Formu</h4>\r\n");
#nullable restore
#line 11 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
             using (Html.BeginForm("UpdateAdmin", "AdminAdmin", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               Write(Html.HiddenFor(x => x.AdminID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label for=\"exampleInputName1\">Admin Adı</label>\r\n                    ");
#nullable restore
#line 16 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               Write(Html.TextBoxFor(x => x.AdminName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               Write(Html.ValidationMessageFor(x => x.AdminName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <label for=\"exampleInputName1\">Şifre</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               Write(Html.TextBoxFor(x => x.AdminPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               Write(Html.ValidationMessageFor(x => x.AdminPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <button class=\"btn btn-primary mr-2\">Güncelle</button>\r\n");
#nullable restore
#line 26 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\UpdateAdmin.cshtml"
               
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.EntityFramework.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
