using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithControllersDemo.Models;

namespace WorkingWithControllersDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greetings = "Hello World From MVC Core";
            ViewBag.Company = "Udemy";
            ViewBag.Country = "India";

            Authors obj = new Authors();
            obj.Name = "John";
            obj.Country = "sample";

            return View(obj);//passing model data to view
        }

        public IActionResult QueryStringDemo(string Message="Hello world from ASP.NET CORE")
        {
            ViewBag.Greetings = Message;
            return View();
        }
        [HttpGet]
        public IActionResult GotoURL(string url="http://www.google.com")
        {
            return (Redirect(url));
        }

        [HttpPost]
        public IActionResult GotoURL(IFormCollection ifc)
        {
            string url = ifc["url"];

            if(url == string.Empty)
            {
                return (Redirect("https://www.google.com"));
            }
            else
            {
                return (Redirect(url));
            }
           
        }
    }
}
