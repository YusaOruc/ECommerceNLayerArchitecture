#pragma checksum "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74552c05cba10e1d68a0860fc383fd89ff6fffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminOrder_Details), @"mvc.1.0.view", @"/Views/AdminOrder/Details.cshtml")]
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
#nullable restore
#line 7 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74552c05cba10e1d68a0860fc383fd89ff6fffa", @"/Views/AdminOrder/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminOrder_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
  double toplam = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Sipariş Tablosu</h4>\r\n");
            WriteLiteral(@"
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>

                            <th>
                                Ürün
                            </th>
                            <th>
                                Ürün Adı
                            </th>
                            <th>
                                Ürün Fiyatı
                            </th>
                            <th>
                                Ürün Adeti
                            </th>
                            <th>
                                Adres Detay
                            </th>
                            

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 56 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 59 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                                   toplam = toplam + (item.Products.ProductPrice * Convert.ToInt32(item.ProductNumber)); toplam = Convert.ToInt32(toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"py-1\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2133, "\"", 2165, 1);
#nullable restore
#line 61 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
WriteAttributeValue("", 2139, item.Products.ProductImg1, 2139, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                               Write(item.Products.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                               Write(item.Products.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                               Write(item.ProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2715, "\"", 2769, 2);
            WriteAttributeValue("", 2722, "/AdminOrderAddressDetails/Index/", 2722, 32, true);
#nullable restore
#line 73 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
WriteAttributeValue("", 2754, item.AddressID, 2754, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">");
#nullable restore
#line 73 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                                                                                                                 Write(item.Addresses.AddressHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </td>\r\n                                \r\n\r\n                            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                    <button style=\"float:right\" class=\"btn btn-inverse-info\">Sayfa toplamı: ");
#nullable restore
#line 92 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
                                                                                       Write(toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</button>\r\n                </table>\r\n                \r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 97 "C:\Users\Yusa\Desktop\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminOrder\Details.cshtml"
       Write(Html.PagedListPager(Model, page => Url.Action("Details", new { page }), new X.PagedList.Web.Common.PagedListRenderOptions
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
