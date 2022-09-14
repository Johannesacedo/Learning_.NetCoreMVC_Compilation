using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithCookies.Models;

namespace WorkingWithCookies.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            //_httpContextAccessor.HttpContext.Response.Cookies.Delete("Username");
            //CookieOptions option = new CookieOptions();
            //option.Expires = DateTime.Now.AddMinutes(5);
            //_httpContextAccessor.HttpContext.Response.Cookies.Append("Username", "Karthik");

            _httpContextAccessor.HttpContext.Session.SetString("MyUserName", "Karthik");
            ViewBag. SessionID = _httpContextAccessor.HttpContext.Session.Id;

            //_httpContextAccessor.HttpContext.Session.Remove("MyUserName");
            //_httpContextAccessor.HttpContext.Session.Clear();
            //string SessionID = _httpContextAccessor.HttpContext.Session.Id;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
