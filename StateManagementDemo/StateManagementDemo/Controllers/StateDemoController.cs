using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementDemo.Controllers
{
    public class StateDemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Ecode"] = 101;
            ViewData["Ename"] = "Conners";
            ViewBag.Message = "This comes from viewbag.message";

            
            if(TempData["Country"] == null)
            {
                TempData.Add("Country", "India");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection ifc)
        {
            return View();
        }
    }
}
