#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8016300c7d43e40f4ec588e2813e321534aa79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminOrder_Index), @"mvc.1.0.view", @"/Views/AdminOrder/Index.cshtml")]
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
#line 6 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8016300c7d43e40f4ec588e2813e321534aa79", @"/Views/AdminOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdminOrder/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Sipariş Tablosu</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da8016300c7d43e40f4ec588e2813e321534aa794972", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <input name=""p"" id=""p"" class=""form-control form-control-sm"" type=""text"" placeholder=""Aramak istediğiniz ürünün adı"">
                    </div>
                    <div class=""col-lg-4"">
                        <button class=""btn btn-inverse-info"">Ara</button>
                    </div>
                </div>


            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            
                            <th>
                                Kullanıcı ID
                            </th>
                            <th>
                                Kullanıcı Adı
                            </th>
                            <th>
                                Kullanıcı Mail
                            </th>
                           <th>Sipariş Onayı</th>
                            <th>
                                Detay
                            </th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 50 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                \r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
                               Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
                               Write(item.UserMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2291, "\"", 2339, 2);
            WriteAttributeValue("", 2298, "/AdminOrder/OrderStatusFalse/", 2298, 29, true);
#nullable restore
#line 64 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
WriteAttributeValue("", 2327, item.UserID, 2327, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Onay</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2490, "\"", 2529, 2);
            WriteAttributeValue("", 2497, "/AdminOrder/Details/", 2497, 20, true);
#nullable restore
#line 67 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
WriteAttributeValue("", 2517, item.UserID, 2517, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Detay</a>\r\n                                </td>\r\n                                \r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 78 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminOrder\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591