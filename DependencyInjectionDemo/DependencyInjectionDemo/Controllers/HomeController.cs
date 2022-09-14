using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISiteVisitorsCounter _counter;

        //SiteVisitorsCounter svc = new SiteVisitorsCounter();


        //Constructor Level dependency injection
        //public HomeController(ILogger<HomeController> logger, ISiteVisitorsCounter counter)
        public HomeController(ILogger<HomeController> logger, ISiteVisitorsCounter counter)
        {
            _logger = logger;
            _counter = counter;
        }

        //action level dependency injection
        //public IActionResult Index([FromServices] ISiteVisitorsCounter counter)
        public IActionResult Index()
        {
            //ViewBag.Counter = svc.GetCounter();
            ViewBag.Counter = _counter.GetCounter();
            ViewBag.Counter = _counter.GetCounter();
            ViewBag.Counter = _counter.GetCounter();
            return View();
        }

        public IActionResult Privacy()
        {
            var siteVisitorsCounterService = (ISiteVisitorsCounter)this.HttpContext.RequestServices.GetService(typeof(ISiteVisitorsCounter));
            ViewBag.Counter = siteVisitorsCounterService.GetCounter();
            //ViewBag.Counter = _counter.GetCounter();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
