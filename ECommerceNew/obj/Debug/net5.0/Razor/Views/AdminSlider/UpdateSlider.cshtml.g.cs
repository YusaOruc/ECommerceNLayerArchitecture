#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51072a4c805fb5c3a353d3d097951eb379528529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminSlider_UpdateSlider), @"mvc.1.0.view", @"/Views/AdminSlider/UpdateSlider.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51072a4c805fb5c3a353d3d097951eb379528529", @"/Views/AdminSlider/UpdateSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminSlider_UpdateSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.EntityFramework.Slider>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
  
    ViewData["Title"] = "UpdateSlider";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Slider Güncelleme Formu</h4>\r\n");
#nullable restore
#line 10 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
             using (Html.BeginForm("UpdateSlider", "AdminSlider", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
               Write(Html.HiddenFor(x => x.SliderID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
               Write(Html.HiddenFor(x => x.SliderImg, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <img style=\"width:100%;height:500px;\"");
            BeginWriteAttribute("src", " src=\"", 718, "\"", 740, 1);
#nullable restore
#line 16 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
WriteAttributeValue("", 724, Model.SliderImg, 724, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                    <br />\r\n                    <label for=\"exampleInputName1\">Başlık</label>\r\n                    ");
#nullable restore
#line 19 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
               Write(Html.TextBoxFor(x => x.SliderHeader, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <label for=\"exampleInputName1\">Açıklama</label>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"
               Write(Html.TextAreaFor(x => x.SliderDescription,10,30, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                </div>\r\n");
            WriteLiteral("                <button class=\"btn btn-primary mr-2\">Güncelle</button>\r\n");
#nullable restore
#line 28 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminSlider\UpdateSlider.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.EntityFramework.Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591