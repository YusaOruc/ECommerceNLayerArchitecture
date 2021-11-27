#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3904d917c08a811b2edfe1004643c4de998768f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductAddToBasket_ProductBasket), @"mvc.1.0.view", @"/Views/ProductAddToBasket/ProductBasket.cshtml")]
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
#line 1 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3904d917c08a811b2edfe1004643c4de998768f0", @"/Views/ProductAddToBasket/ProductBasket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductAddToBasket_ProductBasket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketProduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
  
    ViewData["Title"] = "ProductBasket";
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
                    <h4>Sepetim</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/HomeProduct/Index/"">Ana Sayfa</a>
                        <a href=""/ShoppingProduct/Index/"">Mağaza</a>
                        <span>Sepetim</span>
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
            <div class=""col-lg-8"">
                <div class=""shopping__cart__table"">

                    <table>
                        <thead>
                            <tr>
                                <th>Ürün</th>

                    ");
            WriteLiteral("            <th>Adet</th>\r\n                                <th>Fiyat</th>\r\n                                <th>");
#nullable restore
#line 40 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                               Write(ViewBag.cookie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                               float toplam = 0; float price = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                             foreach (var item in Model)
                            {
                                toplam = toplam + (float)item.BasketProductPrice * item.BasketProductNumber;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"product__cart__item\">\r\n                                        <div class=\"product__cart__item__pic\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 2003, 2);
            WriteAttributeValue("", 1942, "/ShoppingProduct/ProductDetails/", 1942, 32, true);
#nullable restore
#line 52 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 1974, item.SelectedBasketProductID, 1974, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"width:100px;height:100px;\"");
            BeginWriteAttribute("src", " src=\"", 2043, "\"", 2071, 1);
#nullable restore
#line 52 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 2049, item.BasketProductImg, 2049, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2072, "\"", 2078, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        </div>\r\n                                        <div class=\"product__cart__item__text\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2261, "\"", 2329, 2);
            WriteAttributeValue("", 2268, "/ShoppingProduct/ProductDetails/", 2268, 32, true);
#nullable restore
#line 55 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 2300, item.SelectedBasketProductID, 2300, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5>");
#nullable restore
#line 55 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                                                                                                                   Write(item.BasketProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 55 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                                                                                                                                              Write(ViewBag.product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n");
            WriteLiteral(@"                                        </div>
                                    </td>
                                   

                                    <td>
                                        <div class=""row"">
                                            <div>
                                                <button style=""border-radius: 30px; height: 30px; width: 30px; background-color:aliceblue; color: brown; ""><a");
            BeginWriteAttribute("href", " href=\"", 2930, "\"", 3004, 2);
            WriteAttributeValue("", 2937, "/ProductAddToBasket/BasketProductNumberDelete/", 2937, 46, true);
#nullable restore
#line 64 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 2983, item.BasketProductID, 2983, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">-</a></button>\r\n                                            </div>\r\n                                            <div class=\"col-2\">\r\n                                                <p style=\"text-align:center;margin-right:5px;\">");
#nullable restore
#line 67 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                                                                                          Write(item.BasketProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                            <br />
                                            <div>
                                                <button style=""border-radius: 30px; height: 30px; width: 30px; background-color:aliceblue; color: brown; ""><a");
            BeginWriteAttribute("href", " href=\"", 3577, "\"", 3648, 2);
            WriteAttributeValue("", 3584, "/ProductAddToBasket/BasketProductNumberAdd/", 3584, 43, true);
#nullable restore
#line 71 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 3627, item.BasketProductID, 3627, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+</a></button>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                    </td>\r\n\r\n                                    <td class=\"cart__price\">");
#nullable restore
#line 77 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                                                        Write(price= (float)item.BasketProductPrice*item.BasketProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td class=\"cart__close\"><a");
            BeginWriteAttribute("href", " href=\"", 4009, "\"", 4079, 2);
            WriteAttributeValue("", 4016, "/ProductAddToBasket/ProductDelete/", 4016, 34, true);
#nullable restore
#line 79 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
WriteAttributeValue("", 4050, item.SelectedBasketProductID, 4050, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-close\"></i></a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                    \r\n\r\n                </div>\r\n                \r\n\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
              ViewBag.BasketPrice = toplam;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                \r\n                <div class=\"cart__total\">\r\n                    <h6>Sepetim</h6>\r\n                    <ul>\r\n                        \r\n                        <li>Toplam <span>");
#nullable restore
#line 99 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ProductAddToBasket\ProductBasket.cshtml"
                                    Write(toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</span></li>
                    </ul>
                    <a href=""/Address/BasketInAddress/"" class=""primary-btn"">Sepeti Onayla</a>
                </div>
            </div>
            

        </div>
    </div>
</section>
<!-- Shopping Cart Section End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
