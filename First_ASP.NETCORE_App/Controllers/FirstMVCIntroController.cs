using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NETCORE_App.Controllers
{
    public class FirstMVCIntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index2()
        {
            return "Hello world from index2";
        }

        public ViewResult Index3()
        {
            return View("Index33");
        }

        //Passing data from controller to view
        public ViewResult Index4()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good morning" : "Good Afternoon";
            return View("Index4",viewModel);
        }
    }
}
