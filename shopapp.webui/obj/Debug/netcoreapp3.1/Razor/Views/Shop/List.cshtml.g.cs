#pragma checksum "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430467dbe6c36859dbe1b991f26fa9f31acab7df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430467dbe6c36859dbe1b991f26fa9f31acab7df", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213899b7f26ee76b2aa6cd650e860185d3df27d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n     ");
#nullable restore
#line 6 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 13 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
               Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 15 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
            }           

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 23 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 862, "\"", 926, 2);
            WriteAttributeValue("", 870, "page-item", 870, 9, true);
#nullable restore
#line 27 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 879, Model.PageInfo.CurrentPage==i+1?"active":"", 880, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 986, "\"", 1019, 2);
            WriteAttributeValue("", 993, "/universiteler?page=", 993, 20, true);
#nullable restore
#line 28 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1013, i+1, 1013, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 29 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>  \r\n");
#nullable restore
#line 32 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1285, "\"", 1349, 2);
            WriteAttributeValue("", 1293, "page-item", 1293, 9, true);
#nullable restore
#line 35 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1302, Model.PageInfo.CurrentPage==i+1?"active":"", 1303, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1409, "\"", 1474, 4);
            WriteAttributeValue("", 1416, "/universiteler/", 1416, 15, true);
#nullable restore
#line 36 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1431, Model.PageInfo.CurrentCategory, 1431, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1462, "?page=", 1462, 6, true);
#nullable restore
#line 36 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1468, i+1, 1468, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 37 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 40 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             

                                                   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
