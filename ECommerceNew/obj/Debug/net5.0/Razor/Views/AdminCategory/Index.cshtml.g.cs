#pragma checksum "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a4c9745dec9ccd720ea5087e75952e151880f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminCategory_Index), @"mvc.1.0.view", @"/Views/AdminCategory/Index.cshtml")]
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
#line 5 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a4c9745dec9ccd720ea5087e75952e151880f7", @"/Views/AdminCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a4c9745dec9ccd720ea5087e75952e151880f74445", async() => {
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
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Kategori Tablosu</h4>

            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>
                                Kategori
                            </th>
                            <th>
                                Sil
                            </th>
                            <th>
                                Güncelle  ");
#nullable restore
#line 28 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
                                     Write(ViewBag.dontDelete);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a id=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 1457, "\"", 1510, 2);
            WriteAttributeValue("", 1464, "/AdminCategory/DeleteCategory/", 1464, 30, true);
#nullable restore
#line 42 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
WriteAttributeValue("", 1494, item.CategoryID, 1494, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a id=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 1671, "\"", 1724, 2);
            WriteAttributeValue("", 1678, "/AdminCategory/UpdateCategory/", 1678, 30, true);
#nullable restore
#line 45 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
WriteAttributeValue("", 1708, item.CategoryID, 1708, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 56 "C:\Users\Yusa\source\repos\ECommerceNew\ECommerceNew\Views\AdminCategory\Index.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591