#pragma checksum "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5fd8ae8a4000abc46d7da26e92405238c88b918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome_Index), @"mvc.1.0.view", @"/Views/AdminHome/Index.cshtml")]
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
#line 1 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
using EntityLayer.Concreate.EntityFramework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fd8ae8a4000abc46d7da26e92405238c88b918", @"/Views/AdminHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ebe395d827a5225b1c94b8ccd1baf4905f253b4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminPanelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-md-12 grid-margin transparent\">\r\n    <div class=\"row\">\r\n\r\n        ");
#nullable restore
#line 12 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
   Write(await Component.InvokeAsync("HomeProductCounter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
   Write(await Component.InvokeAsync("HomeCategoryCounter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
   Write(await Component.InvokeAsync("HomeUserCounter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\Yusa\Desktop\Bitirme Projesi\ECommerceNLayerArchitecture\ECommerceNew\Views\AdminHome\Index.cshtml"
   Write(await Component.InvokeAsync("HomeOrderCounter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"    </div>

    <div class=""card data-icon-card-primary"">
        <div class=""card-body"">
            <p style=""float:right"" class=""card-title text-white"">T??yolar </p>
            <div class=""row"">
                <div class=""col-10 text-white"">
                    <h3 style=""text-decoration: underline;"">Foto??raf Se??imi</h3>
                    <br />
                    <p class=""text-white font-weight-500 mb-0"">- Foto??raflar?? l??tfen y??ksek ????z??n??rl??kte y??kleyiniz. </p>
                    <br />
                    <p class=""text-white font-weight-500 mb-0"">- ??r??n foto??raflar??n?? kare olarak y??kleyiniz. </p>
                    <br />
                    <p class=""text-white font-weight-500 mb-0"">- Ana sayfada bulunan ge??i??li foto??raflar?? sitenin temas??na uygun olarak se??iniz.. </p>
                    <br />
                    <h3 style=""text-decoration: underline;"">Silme ????lemi</h3>
                    <br />
                    <p class=""text-white font-weight-500 mb-0"">- Emin olmadan si");
            WriteLiteral(@"lme i??lemi yapmay??n??z </p>
                    <br />
                    <p class=""text-white font-weight-500 mb-0"">- Bir KATEGOR?? ismini silmek isterseniz ona ba??l?? olan ??r??nleri silmeniz veya kategorisini g??ncellemeniz gerekmektedir. </p>
                </div>
                <div class=""col-2 background-icon"">
                    <a href=""#""></a>
                </div>
            </div>
        </div>
    </div>


</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
