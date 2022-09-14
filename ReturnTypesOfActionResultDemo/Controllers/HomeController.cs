using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using ReturnTypesOfActionResultDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypesOfActionResultDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        //generic return types
        public IActionResult Index()
        {
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

        //specific return types

        public ContentResult GreetUser()
        {
            //return Content("Hello world From MVC Core");
            //return Content("<div><b>Hello world from MVC Core </b></div>","text/html");
            //return Content("<div><b>Hello world from MVC Core </b></div>", "text/xml");

            return (Content(_environment.ContentRootPath));
            //return (Content(_environment.WebRootPath));
        }

        public ViewResult WishUser(string Message = "Default Message")
        {
            ViewBag.Message=Message;
            return View();
        }

        public RedirectResult GotoURL()
        {
            //HTTP Status Code:302
            return Redirect("http://www.google.com");
        }

        public RedirectResult GotoURLPermanently()
        {
            //HTTP Status Code:301
            return RedirectPermanent("http://wwww.google.com");
        }

        public RedirectToActionResult GotoContactsAction()
        {
            return RedirectToAction("WishUser", new { Message = "Hey! I am comming from a different action...." });
        }

        public RedirectToRouteResult GotoAbout()
        {
            return (RedirectToRoute("WishUser"));
        }

        public FileResult DownloadFile()
        {
            return File("/css/site.css", "text/plain", "newsite.css");
        }
        public FileResult ShowLogo()
        {
            return File("./Images/logo.png", "images/png");
        }

        public FileContentResult DownloadContent()
        {
            var myfile = System.IO.File.ReadAllBytes("./wwwroot/css/site.css");
            return new FileContentResult(myfile, "text/plain");

            //var myfile = System.IO.File.ReadAllBytes("./Data/Products.xml");
            //return new FileContentResult(myfile, "text/plain");
        }

        public FileStreamResult CreateFile()
        {
            var stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello World"));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {
                FileDownloadName = "test.txt"
            };
        }

        public VirtualFileResult VirtualFileResultDemo()
        {
            return new VirtualFileResult("/css/site.css", "text/plain");
        }

        public PhysicalFileResult ShowProducts()
        {
            return new PhysicalFileResult(_environment.ContentRootPath + "/Data/Products.xml", "text/xml");
        }

        public PhysicalFileResult PhysicalFileResultDemo()
        {
            return new PhysicalFileResult(_environment.ContentRootPath + "/wwwroot/css/site.css", "text/plain");
        }

        public JsonResult ShowNewProducts()
        {
            Products prod = new Products() { ProductCode = 101, ProductName = "Printer", Cost = 1500 };
            return Json(prod);
        }

        public EmptyResult EmptyResultDemo()
        {
            //http status code 200 will lead to a blank screen
            return new EmptyResult();
        }

        public NoContentResult NoContentResultDemo()
        {
            //http status code 204
            return NoContent();
        }
         
        public BadRequestResult BRRDemo()
        {
            //status code 400
            return BadRequest();
        }

        public StatusCodeResult ReturnBadRequest()
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        public BadRequestObjectResult BadRequestObjectResultDemo()
        {
            var modelState = new ModelStateDictionary();
            modelState.AddModelError("br", "Bad Request.");
            return BadRequest(modelState);
        }

        public UnauthorizedResult UnauthorizedResultDemo()
        {
            return Unauthorized();
        }

        public UnauthorizedObjectResult UnauthorizedObjectResultDemo()
        {
            var modelState = new ModelStateDictionary();
            modelState.AddModelError("br", "You are not authorized to visit this area.");
            return Unauthorized(modelState);
        }

        public NotFoundResult ReturnNotFound()
        {
            return NotFound();
        }

        public NotFoundObjectResult NotFoundObjectResult()
        {
            return NotFound(new { CustomerId = 1, error = "Not Found that CusotmerId" });
        }

        public OkObjectResult ReturnOk()
        {
            return Ok(new string[] { "O", "K", "A", "Y" });
        }

        public OkObjectResult OkObjectResult()
        {
            return new OkObjectResult(new { Message = " OKAY" });
        }

        public PartialViewResult ShowChildViewContent()
        {
            Products prod = new Products();
            prod.ProductCode = 101;
            prod.ProductName = "Keyboard";
            prod.Cost = 3000;

            return PartialView(prod);

        }
    }
}
