#pragma checksum "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9acc050620fec6337602ead9596970fd2313ae1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\_ViewImports.cshtml"
using ViewComponentsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\_ViewImports.cshtml"
using ViewComponentsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acc050620fec6337602ead9596970fd2313ae1c", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc49734945697a902eb60e6aea5a41b7bed8b07", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewComponentsDemo.Models.Product>>
    {
        private global::AspNetCore.Views_Products_Index.__Generated__ProductSummaryViewComponentTagHelper __ProductSummaryViewComponentTagHelper;
        private global::AspNetCore.Views_Products_Index.__Generated__ProductsControllerHybridViewComponentTagHelper __ProductsControllerHybridViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9acc050620fec6337602ead9596970fd2313ae1c4147", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 66 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 67 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Summary", async() => {
                WriteLiteral("\r\n    <div class=\"bg-info text-white m-2 p-2\">\r\n");
                WriteLiteral("        ");
#nullable restore
#line 77 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
   Write(await Component.InvokeAsync("ProductSummary", new { units = 45 }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"bg-info text-white m-2 p-2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:product-summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9acc050620fec6337602ead9596970fd2313ae1c12737", async() => {
                }
                );
                __ProductSummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Products_Index.__Generated__ProductSummaryViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__ProductSummaryViewComponentTagHelper);
#nullable restore
#line 80 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\ViewComponentsDemo\ViewComponentsDemo\Views\Products\Index.cshtml"
__ProductSummaryViewComponentTagHelper.Units = 45;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("units", __ProductSummaryViewComponentTagHelper.Units, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div class=\"bg-info text-white m-2 p-2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:products-controller-hybrid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9acc050620fec6337602ead9596970fd2313ae1c14239", async() => {
                }
                );
                __ProductsControllerHybridViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Products_Index.__Generated__ProductsControllerHybridViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__ProductsControllerHybridViewComponentTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewComponentsDemo.Models.Product>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:product-summary")]
        public class __Generated__ProductSummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ProductSummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 Units { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ProductSummary", new { Units });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:products-controller-hybrid")]
        public class __Generated__ProductsControllerHybridViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ProductsControllerHybridViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ProductsControllerHybrid", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
