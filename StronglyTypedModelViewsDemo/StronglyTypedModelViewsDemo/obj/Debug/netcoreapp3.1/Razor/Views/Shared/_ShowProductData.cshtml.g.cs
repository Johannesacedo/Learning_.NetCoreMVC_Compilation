#pragma checksum "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f623d06bf6eb25e463988a439375a3c148690495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShowProductData), @"mvc.1.0.view", @"/Views/Shared/_ShowProductData.cshtml")]
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
#line 1 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\_ViewImports.cshtml"
using StronglyTypedModelViewsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\_ViewImports.cshtml"
using StronglyTypedModelViewsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f623d06bf6eb25e463988a439375a3c148690495", @"/Views/Shared/_ShowProductData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2495a0d530d41d9de601692923d347c8874b586", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShowProductData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StronglyTypedModelViewsDemo.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 5 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 8 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 11 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 14 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 17 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 20 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 23 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 26 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 29 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=Model.ProductID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 30 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=Model.ProductID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 31 "D:\SoftwareDevelopment\ASP.NET CORE 5.0_3.1 MVC\StronglyTypedModelViewsDemo\StronglyTypedModelViewsDemo\Views\Shared\_ShowProductData.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=Model.ProductID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StronglyTypedModelViewsDemo.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591