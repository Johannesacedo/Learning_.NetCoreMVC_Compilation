#pragma checksum "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\MyCustomTagHelpersDemo\MyCustomTagHelpersDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecce1d3ef5effee1657876a7becd75b160254d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\MyCustomTagHelpersDemo\MyCustomTagHelpersDemo\Views\_ViewImports.cshtml"
using MyCustomTagHelpersDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\MyCustomTagHelpersDemo\MyCustomTagHelpersDemo\Views\_ViewImports.cshtml"
using MyCustomTagHelpersDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ecce1d3ef5effee1657876a7becd75b160254d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870488d433e5a515caa950c4d8ff91d85ea9ed51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "warning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "danger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\MyCustomTagHelpersDemo\MyCustomTagHelpersDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<table class=""table table-striped table-bordered table-sm"">
    <thead>
        <tr>
            <th colspan=""2"">Employee Details</th>
        </tr>
    </thead>
    <tbody>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d15322", async() => {
                WriteLiteral("\r\n            <th>EmployeeID</th>\r\n            <td>1</td>\r\n        ");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d16333", async() => {
                WriteLiteral("\r\n            <th>\r\n                Employee Name\r\n            </th>\r\n            <td>\r\n                Connors McGreggor\r\n            </td>\r\n        ");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d17435", async() => {
                WriteLiteral("\r\n            <th>Salary</th>\r\n            <td>5000</td>\r\n        ");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<table class=\"table table-striped table-bordered table-sm\">\r\n    <thead>\r\n        <tr bg-color=\"info\" text-color=\"white\">\r\n            <th colspan=\"2\">Employee Details</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d18711", async() => {
                WriteLiteral("<th>Employee</th><td>1</td>");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.BgColor = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("text-center", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.TextColor = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d110386", async() => {
                WriteLiteral("<th>Employee Name</th><td>Connors McGreggor</td>");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.BgColor = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.TextColor = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecce1d3ef5effee1657876a7becd75b160254d111769", async() => {
                WriteLiteral("<th>Salary</th><td bg-color=\"dark\">5000</td>");
            }
            );
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper = CreateTagHelper<global::MyCustomTagHelpersDemo.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__MyCustomTagHelpersDemo_TagHelpers_TrTagHelper);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.BgColor = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __MyCustomTagHelpersDemo_TagHelpers_TrTagHelper.TextColor = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591