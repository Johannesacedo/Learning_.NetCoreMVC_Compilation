using Introduction_to_ASP.NET_CORE_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction_to_ASP.NET_CORE_MVC.Middlewares
{
    public class EmployeeLocationMiddleWare
    {
        private RequestDelegate next;
        private EmployeeLocationOptions options;
        
        public EmployeeLocationMiddleWare(RequestDelegate nextDelegate, IOptions<EmployeeLocationOptions> opts)
        {
            next = nextDelegate;
            options = opts.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path == "/Employeelocation")
            {
                await context.Response.WriteAsync($"\n{options.CityName}, {options.CountryName}");
            }
            else
            {
                await next(context);
            }
        }
    }
}
