#pragma checksum "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Home\MyView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158046059b8169ca440f4cb5f99ee1543bc04a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyView), @"mvc.1.0.view", @"/Views/Home/MyView.cshtml")]
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
#line 2 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158046059b8169ca440f4cb5f99ee1543bc04a33", @"/Views/Home/MyView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213899b7f26ee76b2aa6cd650e860185d3df27d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <div class=\"row pt-5\">\r\n    <div class=\"col-md-12 pt-5\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 6 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Home\MyView.cshtml"
             foreach (var category in Model.Categories)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 9 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Home\MyView.cshtml"
               Write(await Html.PartialAsync("_categoryView", category));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 11 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Home\MyView.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div> \r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
