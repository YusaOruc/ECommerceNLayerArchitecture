#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca4e2377e28910545e9b718d6d03539ee1ca178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingProduct_Index), @"mvc.1.0.view", @"/Views/ShoppingProduct/Index.cshtml")]
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
#line 1 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca4e2377e28910545e9b718d6d03539ee1ca178", @"/Views/ShoppingProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:transparent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/malefashion-master/img/icon/fav.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
  
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
                    <h4>Mağaza</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/HomeProduct/Index"">Ana Sayfa</a>
                        <span>Mağaza</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shop Section Begin -->

<section class=""shop spad"">
    <div class=""container"">
        <div class=""row"">
            <br /><br /><br />
            ");
#nullable restore
#line 31 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
       Write(await Component.InvokeAsync("ShoppingCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <div class=""col-lg-9"">
                <div class=""shop__product__option"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__left"">

                                <p>Showing 1–12 of 126 results  </p>
                                
                                
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 48 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                            <div class=\"product__item\">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 52 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
                                                                              Write(item.ProductImg1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <a style=\"border-style: none;\"");
            BeginWriteAttribute("href", " href=\"", 1862, "\"", 1916, 2);
            WriteAttributeValue("", 1869, "/ShoppingProduct/ProductDetails/", 1869, 32, true);
#nullable restore
#line 53 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
WriteAttributeValue("", 1901, item.ProductID, 1901, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"width:100%;height:100%;\"");
            BeginWriteAttribute("alt", " alt=\"", 1954, "\"", 1960, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                    \r\n                                    <ul class=\"product__hover\">\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2117, "\"", 2223, 2);
#nullable restore
#line 56 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
WriteAttributeValue("", 2124, User.Identity.Name==null?"/Login/Index/":"/ProductAddToFavorite/ProductFavorite/", 2124, 84, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
WriteAttributeValue("", 2208, item.ProductID, 2208, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fca4e2377e28910545e9b718d6d03539ee1ca1788639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"product__item__text\">\r\n                                    <h6>");
#nullable restore
#line 61 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    \r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2621, "\"", 2715, 2);
#nullable restore
#line 63 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
WriteAttributeValue("", 2628, User.Identity.Name==null?"/Login/Index/":"/ProductAddToBasket/Index/", 2628, 72, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
WriteAttributeValue("", 2700, item.ProductID, 2700, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"add-cart\">+ Sepete Ekle</a>\r\n                                    \r\n                                    \r\n\r\n                                    <h5>");
#nullable restore
#line 67 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"
                                   Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h5>\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 72 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\ShoppingProduct\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Shop Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
