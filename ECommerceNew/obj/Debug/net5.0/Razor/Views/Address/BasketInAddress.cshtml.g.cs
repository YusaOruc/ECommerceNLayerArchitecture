#pragma checksum "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\Address\BasketInAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6471b483aa1ad52c27d5f81a9d3b1a12b10c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_BasketInAddress), @"mvc.1.0.view", @"/Views/Address/BasketInAddress.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6471b483aa1ad52c27d5f81a9d3b1a12b10c1c", @"/Views/Address/BasketInAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Address_BasketInAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.EntityFramework.Address>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 210px; position: relative; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/malefashion-master/img/shoping.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\Address\BasketInAddress.cshtml"
  
    ViewData["Title"] = "BasketInAddress";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6471b483aa1ad52c27d5f81a9d3b1a12b10c1c4751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    
    
    <!-- Breadcrumb Section Begin -->
    <section class=""breadcrumb-option"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb__text"">
                        <h4>Sepetim</h4>
                        <div class=""breadcrumb__links"">
                            <a href=""/HomeProduct/Index/"">Ana Sayfa</a>
                            <a href=""/ProductAddToBasket/ProductBasket/"">Sepetim</a>
                            <span>Adresim</span>
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
                <div class=""col-lg-6"">
                    <div class=""cart__total"">
                ");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b6471b483aa1ad52c27d5f81a9d3b1a12b10c1c6878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""cart__total"">
                        <div class=""shopping__cart__table"" style=""height:180px;"">



                            <h4 style=""font-weight:bold"">Adres Se??imi</h4>
                            <hr />

");
#nullable restore
#line 50 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\Address\BasketInAddress.cshtml"
                             using (Html.BeginForm("AddOrder", "Order", FormMethod.Post))
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\Address\BasketInAddress.cshtml"
                           Write(Html.DropDownListFor(x => x.AddressID, (List<SelectListItem>)ViewBag.ListAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <br />\r\n");
            WriteLiteral("                                <br />\r\n");
            WriteLiteral("                                <hr />\r\n");
            WriteLiteral("                                <div class=\"form-check\">\r\n                                    <input id=\"check\" class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2241, "\"", 2249, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label class=""form-check-label"" for=""flexCheckIndeterminate"">
                                        S??zle??meyi <a href=""#"">Link</a> okudum kabul ediyorum.
                                    </label>
                                </div>
                                <br />
                                <button disabled id=""btn1"" style=""width: 55%;float:right"" class=""primary-btn"">Sipari??i Tamamla</button>
");
            WriteLiteral("                                <a style=\"height:47px;float:left\" href=\"/Address/AddressAdd/\" class=\"btn btn-secondary\">Yeni Adres Ekle</a>\r\n");
#nullable restore
#line 71 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\Address\BasketInAddress.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>


                    </div>


                </div>

            </div>
        </div>
    </section>
    <script>
        $('#btn1').click(function () {
            document.getElementById(""btn1"").style.visibility = 'hidden';
            swal(""Te??ekk??r Ederiz!"", ""Sipari??iniz Al??nm????t??r!"", ""success"");
        })

    </script>
    <script>
        $('#check').click(function () {
            /* document.getElementById(""RegisterBtn"").style.visibility = 'hidden';*/
            if (document.getElementById(""check"").checked) {
                document.getElementById(""btn1"").disabled = false;
            } else {
                document.getElementById(""btn1"").disabled = true;
            }

            /*swal(""Te??ekk??r Ederiz!"", ""Sipari??iniz Al??nm????t??r!"", ""success"");*/
        })

    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.EntityFramework.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
