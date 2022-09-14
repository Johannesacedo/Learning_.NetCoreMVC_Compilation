using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomFiltersDemo.filters
{
    public class MyAsyncCustomActionFilter : Attribute,IAsyncActionFilter, IAsyncResultFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }

        public Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            throw new NotImplementedException();
        }

        public void DoLogging(string FunctionName, RouteData routeData, HttpContext _httpContext)
        {
            string Controller, Action;
            Controller = routeData.Values["controller"].ToString();
            Action = routeData.Values["action"].ToString();
            string str = string.Format("1-Function Name ={0}, Controller Name={1},Action={2}", FunctionName, Controller, Action);
            _httpContext.Response.WriteAsync("<br>" + str + "<br>");
        }
    }
}
