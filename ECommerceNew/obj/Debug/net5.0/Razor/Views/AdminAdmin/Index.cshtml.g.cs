#pragma checksum "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e9919a4cffb84b79eba958f04763f3b1f8b8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminAdmin_Index), @"mvc.1.0.view", @"/Views/AdminAdmin/Index.cshtml")]
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
#line 6 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e9919a4cffb84b79eba958f04763f3b1f8b8ea", @"/Views/AdminAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Admin Tablosu</h4>

            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>
                                Admin ID
                            </th>
                            <th>
                                Admin Adı
                            </th>
                            <th>
                                Admin Şifresi
                            </th>
                            <th>
                                Sil
                            </th>
                            <th>
                                Güncelle 
                            </th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
                           Write(item.AdminID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
                           Write(item.AdminName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
                           Write(item.AdminPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a id=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 1742, "\"", 1786, 2);
            WriteAttributeValue("", 1749, "/AdminAdmin/DeleteAdmin/", 1749, 24, true);
#nullable restore
#line 53 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
WriteAttributeValue("", 1773, item.AdminID, 1773, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                            </td>\r\n                            <td>\r\n                                <a id=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 1979, 2);
            WriteAttributeValue("", 1942, "/AdminAdmin/UpdateAdmin/", 1942, 24, true);
#nullable restore
#line 56 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
WriteAttributeValue("", 1966, item.AdminID, 1966, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 67 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminAdmin\Index.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
