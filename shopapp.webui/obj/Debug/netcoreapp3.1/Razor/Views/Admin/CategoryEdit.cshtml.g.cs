#pragma checksum "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd4ea09426b8fa90387b61fd4702b05afb337e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryEdit), @"mvc.1.0.view", @"/Views/Admin/CategoryEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd4ea09426b8fa90387b61fd4702b05afb337e8", @"/Views/Admin/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213899b7f26ee76b2aa6cd650e860185d3df27d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletefromcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h3\">??lkeyi D??zenle</h1>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd4ea09426b8fa90387b61fd4702b05afb337e87852", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd4ea09426b8fa90387b61fd4702b05afb337e88118", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 8 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 338, "\"", 363, 1);
#nullable restore
#line 9 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 346, Model.CategoryId, 346, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">??lke Ad??</label>\r\n            <div class=\"col-sm-10\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efd4ea09426b8fa90387b61fd4702b05afb337e810406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 13 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd4ea09426b8fa90387b61fd4702b05afb337e812007", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 14 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Uzant??s??n?? Girin</label>\r\n            <div class=\"col-sm-10\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efd4ea09426b8fa90387b61fd4702b05afb337e813886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 20 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd4ea09426b8fa90387b61fd4702b05afb337e815486", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 21 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div> \r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-2 col-form-label\">Foto??raf Se??in</label>\r\n            <div class=\"col-sm-10\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efd4ea09426b8fa90387b61fd4702b05afb337e817363", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 27 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryImageUrl);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efd4ea09426b8fa90387b61fd4702b05afb337e819104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1254, "~/img/", 1254, 6, true);
#nullable restore
#line 28 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 1260, Model.CategoryImageUrl, 1260, 23, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 1302, Model.Name, 1302, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <input type=""file"" name=""file"">
            </div>
        </div>  
        <div class=""form-group row"">
            <div class=""col-sm-10 offset-sm-2"">
                <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
            </div>
        </div>
         <div id=""products"">

");
#nullable restore
#line 39 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
             for (int i = 0; i < Model.Products.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1751, "\"", 1780, 3);
                WriteAttributeValue("", 1758, "Products[", 1758, 9, true);
#nullable restore
#line 41 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1767, i, 1767, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1769, "].ProductId", 1769, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1781, "\"", 1818, 1);
#nullable restore
#line 41 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1789, Model.Products[@i].ProductId, 1789, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1858, "\"", 1886, 3);
                WriteAttributeValue("", 1865, "Products[", 1865, 9, true);
#nullable restore
#line 42 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1874, i, 1874, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1876, "].ImageUrl", 1876, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1887, "\"", 1923, 1);
#nullable restore
#line 42 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1895, Model.Products[@i].ImageUrl, 1895, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1963, "\"", 1987, 3);
                WriteAttributeValue("", 1970, "Products[", 1970, 9, true);
#nullable restore
#line 43 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1979, i, 1979, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1981, "].Name", 1981, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1988, "\"", 2020, 1);
#nullable restore
#line 43 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1996, Model.Products[@i].Name, 1996, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2060, "\"", 2090, 3);
                WriteAttributeValue("", 2067, "Products[", 2067, 9, true);
#nullable restore
#line 44 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2076, i, 2076, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2078, "].IsApproved", 2078, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2091, "\"", 2140, 1);
#nullable restore
#line 44 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2099, Model.Products[@i].IsApproved.ToString(), 2099, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">                                   \r\n");
#nullable restore
#line 45 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-8"">        
        <div class=""row"">
            <div class=""col-md-12"">   
                <table class=""table table-bordered table-sm"">
                    <thead>
                        <tr>
                            <td style=""width: 30px;"">Id</td>
                            <td style=""width: 100px;"">Foto??raf</td>
                            <td>??niversite Ad??</td>
                            <td style=""width: 20px;"">Onayl??</td>
                            <td style=""width: 150px;"">Se??enekler</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 63 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                         if(Model.Products.Count>0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                             foreach (var item in Model.Products)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 68 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                       Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efd4ea09426b8fa90387b61fd4702b05afb337e829232", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3215, "~/img/", 3215, 6, true);
#nullable restore
#line 69 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 3221, item.ImageUrl, 3221, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 69 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 3253, item.Name, 3253, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 3263, "??niversitesi", 3264, 13, true);
#nullable restore
#line 69 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue(" ", 3276, item.Name, 3277, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 3287, "universitesi", 3288, 13, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 72 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                             if(item.IsApproved)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 75 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 77 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3937, "\"", 3975, 2);
            WriteAttributeValue("", 3944, "/admin/products/", 3944, 16, true);
#nullable restore
#line 80 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 3960, item.ProductId, 3960, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">D??zenle</a>\r\n                                            \r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd4ea09426b8fa90387b61fd4702b05afb337e833788", async() => {
                WriteLiteral("\r\n                                                <input alt=\"Submit\" type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4296, "\"", 4319, 1);
#nullable restore
#line 83 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4304, item.ProductId, 4304, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <input alt=\"Submit\" type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 4422, "\"", 4447, 1);
#nullable restore
#line 84 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4430, Model.CategoryId, 4430, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                </tr>\r\n");
#nullable restore
#line 89 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                 
                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-warning\">\r\n                                <h3>??r??n Yok..</h3>\r\n                            </div>\r\n");
#nullable restore
#line 94 "D:\EgitimWeb_Buldum\heyy\userOlmadan3\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/modules/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n    <script src=\"/modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
