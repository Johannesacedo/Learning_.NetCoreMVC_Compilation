#pragma checksum "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\WorkingWithControllersDemo\Views\ShowURLElements\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6353ad628f047c19e7d3b964fbe96ddaafcc0376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowURLElements_Index), @"mvc.1.0.view", @"/Views/ShowURLElements/Index.cshtml")]
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
#line 1 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\WorkingWithControllersDemo\Views\_ViewImports.cshtml"
using WorkingWithControllersDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\WorkingWithControllersDemo\Views\_ViewImports.cshtml"
using WorkingWithControllersDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6353ad628f047c19e7d3b964fbe96ddaafcc0376", @"/Views/ShowURLElements/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284be6df9ffb1f5d0cabf73ef42cccfaac2a9ef9", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowURLElements_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\WorkingWithControllersDemo\Views\ShowURLElements\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h1>Your URL Route Data is as Below....</h1>\r\n<h1>");
#nullable restore
#line 9 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\WorkingWithControllersDemo\Views\ShowURLElements\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
