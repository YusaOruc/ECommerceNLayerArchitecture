#pragma checksum "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bb57b150ef2da8e37480a29d0010cef7ab1ed58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyOrders_Index), @"mvc.1.0.view", @"/Views/MyOrders/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb57b150ef2da8e37480a29d0010cef7ab1ed58", @"/Views/MyOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
  
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
                    <h4>Sipari??lerim</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/HomeProduct/Index/"">Ana Sayfa</a>
                        <span>Sipari??lerim</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shopping Cart Section Begin -->
<section class=""shopping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shopping__cart__table"">

                    <table>
                        <thead>
                            <tr>
                                <th>??r??n</th>
                                <th>??r??n AD??</th>
                              ");
            WriteLiteral("  <th>Adet</th>\r\n                                <th>Fiyat</th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"product__cart__item\">\r\n                                        <div class=\"product__cart__item__pic\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1775, "\"", 1829, 2);
            WriteAttributeValue("", 1782, "/ShoppingProduct/ProductDetails/", 1782, 32, true);
#nullable restore
#line 52 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
WriteAttributeValue("", 1814, item.ProductID, 1814, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"width:100px;height:100px;\"");
            BeginWriteAttribute("src", " src=\"", 1869, "\"", 1901, 1);
#nullable restore
#line 52 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
WriteAttributeValue("", 1875, item.Products.ProductImg1, 1875, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1902, "\"", 1908, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        </div>\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2093, "\"", 2147, 2);
            WriteAttributeValue("", 2100, "/ShoppingProduct/ProductDetails/", 2100, 32, true);
#nullable restore
#line 57 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
WriteAttributeValue("", 2132, item.ProductID, 2132, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5>");
#nullable restore
#line 57 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
                                                                                                 Write(item.Products.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n                                    </td>\r\n\r\n                                    <td>\r\n\r\n                                        <p>");
#nullable restore
#line 62 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
                                      Write(item.ProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                                    </td>\r\n\r\n                                    <td class=\"cart__price\">");
#nullable restore
#line 67 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
                                                        Write((float)item.Products.ProductPrice*item.ProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <br />\r\n                    ");
#nullable restore
#line 76 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\MyOrders\Index.cshtml"
               Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page }), new X.PagedList.Web.Common.PagedListRenderOptions
                     {
                              DisplayLinkToIndividualPages = true,
                              DisplayPageCountAndCurrentLocation = false,
                              MaximumPageNumbersToDisplay = 10,
                              LiElementClasses = new string[] { "page-item" },
                         PageClasses = new string[] { "page-link" },

                          }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        \r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Shopping Cart Section End -->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
