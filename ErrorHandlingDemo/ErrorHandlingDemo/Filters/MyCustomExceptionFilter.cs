using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandlingDemo.Filters
{
    public class MyCustomExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext filtercontext)
        {
            ViewResult result = new ViewResult();
            result.ViewName = "/Views/Shared/ErrorMessage.cshtml";

            result.ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());
            result.ViewData.Model = filtercontext.Exception;
            result.ViewData["Controller"] = (string)filtercontext.RouteData.Values["controller"];
            result.ViewData["Action"] = (string)filtercontext.RouteData.Values["action"];

            filtercontext.Result = result;
            filtercontext.ExceptionHandled = true;
        }
    }
}
