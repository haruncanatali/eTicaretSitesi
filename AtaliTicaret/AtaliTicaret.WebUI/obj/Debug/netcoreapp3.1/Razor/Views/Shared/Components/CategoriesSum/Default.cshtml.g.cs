#pragma checksum "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd017e825edee55993530b5de23488ca6e51b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoriesSum_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoriesSum/Default.cshtml")]
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
#line 1 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\_ViewImports.cshtml"
using AtaliTicaret.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\_ViewImports.cshtml"
using AtaliTicaret.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\_ViewImports.cshtml"
using AtaliTicaret.Entites.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd017e825edee55993530b5de23488ca6e51b59", @"/Views/Shared/Components/CategoriesSum/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6052f8e106beadb40e7f9dfb668f59683dc06b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoriesSum_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryProductsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item disabled\" style=\"background-color: blueviolet;\"><span class=\"font-weight-bold h5\" style=\"color:white;\">Kategoriler</span></li>  \r\n");
#nullable restore
#line 10 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
             foreach (Category category in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd017e825edee55993530b5de23488ca6e51b595126", async() => {
#nullable restore
#line 13 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
                                                                                                                  Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp; (");
#nullable restore
#line 13 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
                                                                                                                                                Write(category.Products.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
                                                                                    WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 15 "E:\derscalismalarim\.netCore Çalışmalarım\Proje12_AtaliTicaret\AtaliTicaret\AtaliTicaret.WebUI\Views\Shared\Components\CategoriesSum\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
