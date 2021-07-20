#pragma checksum "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9042880a21447a7f6a197101e0814bfeb70c4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CompanyList), @"mvc.1.0.view", @"/Views/Admin/CompanyList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9042880a21447a7f6a197101e0814bfeb70c4a", @"/Views/Admin/CompanyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213899b7f26ee76b2aa6cd650e860185d3df27d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CompanyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Şirket Bilgilerini Düzenle</h1>
        <hr>
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width: 30px;"">Id</td>
                    <td>Şirket Adı</td>
                    <td>Şirket Numarası</td>
                    <td>Şirket Adresi</td>
                    <td>Şirketin Email Adresi</td>
                    <td>Seçenekler</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                 if(Model.Companies.Count>0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                        foreach (var item in Model.Companies)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 24 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                               Write(item.CompanyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 25 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                                <td>");
#nullable restore
#line 26 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                               Write(item.CompanyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                                <td>");
#nullable restore
#line 27 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                               Write(item.CompanyAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                                <td>");
#nullable restore
#line 28 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                               Write(item.CompanyEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1163, "\"", 1202, 2);
            WriteAttributeValue("", 1170, "/admin/companies/", 1170, 17, true);
#nullable restore
#line 30 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
WriteAttributeValue("", 1187, item.CompanyId, 1187, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Düzenle</a>\r\n                                    \r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 34 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>Şirket Bilgisi yok..</h3>\r\n                    </div>\r\n");
#nullable restore
#line 39 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CompanyList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591