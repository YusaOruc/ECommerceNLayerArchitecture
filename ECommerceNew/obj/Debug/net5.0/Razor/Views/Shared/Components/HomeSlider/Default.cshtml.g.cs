#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3726aa3930ff2b6cf1d2b5bfdb598b40e1d6f93f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeSlider/Default.cshtml")]
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
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3726aa3930ff2b6cf1d2b5bfdb598b40e1d6f93f", @"/Views/Shared/Components/HomeSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<section  class=\"hero\">\n    <div  class=\"hero__slider owl-carousel\">\n");
#nullable restore
#line 7 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div  class=\"hero__items set-bg\" data-setbg=\"");
#nullable restore
#line 9 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
                                                    Write(item.SliderImg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n");
            WriteLiteral("                <div class=\"container\">\n                    <div class=\"row\">\n                        <div class=\"col-xl-5 col-lg-7 col-md-8\">\n                            <div class=\"hero__text\" >\n\n                                <h2>");
#nullable restore
#line 16 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
                               Write(item.SliderHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n                                <p>\n                                    \n                                    ");
#nullable restore
#line 19 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
                               Write(item.SliderDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <a href=""/ShoppingProduct/Index/"" class=""primary-btn"">İncele <span class=""arrow_right""></span></a>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 28 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\Shared\Components\HomeSlider\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
