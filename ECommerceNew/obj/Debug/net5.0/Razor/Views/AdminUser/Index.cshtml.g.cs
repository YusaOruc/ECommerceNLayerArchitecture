#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2242402c271070d61406b67a709d999d05e656b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUser_Index), @"mvc.1.0.view", @"/Views/AdminUser/Index.cshtml")]
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
#line 6 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2242402c271070d61406b67a709d999d05e656b5", @"/Views/AdminUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdminUser/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Kullanıcı Tablosu</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2242402c271070d61406b67a709d999d05e656b54999", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <input name=""p""id=""p"" class=""form-control form-control-sm"" type=""text"" placeholder=""Aramak istediğiniz kullanıcının adı"">
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
                                Kullanıcı Şifresi
                            </th>
                            <th>
                                Telefon numarası
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
#line 55 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
                               Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ************\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
                               Write(item.UserNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2575, "\"", 2616, 2);
            WriteAttributeValue("", 2582, "/AdminUser/DeleteUser/", 2582, 22, true);
#nullable restore
#line 71 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 2604, item.UserID, 2604, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2765, "\"", 2807, 2);
            WriteAttributeValue("", 2772, "/AdminUser/UpdateUsers/", 2772, 23, true);
#nullable restore
#line 74 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
WriteAttributeValue("", 2795, item.UserID, 2795, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n\r\n            ");
#nullable restore
#line 86 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminUser\Index.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
