using EmployeeManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagerApp.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db = null;
        public EmployeeManagerController(AppDbContext db)
        {
            this.db = db;
        }

        private void FillCountries()
        {
            List<SelectListItem> countries = (from c in db.Countries
                                              orderby c.Name ascending
                                              select new SelectListItem() { Text = c.Name, Value = c.Name }).ToList();

            ViewBag.Countries = countries;
        }

        [HttpGet]
        public IActionResult Create()
        {
            FillCountries();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            FillCountries();
            if (ModelState.IsValid)
            {
                db.Employee.Add(emp);
                db.SaveChanges();
            }
            return View(emp);
        }

        public IActionResult Index()
        {
            List<Employee> model = (from e in db.Employee orderby e.EmployeeID select e).ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            Employee model = db.Employee.Find(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            FillCountries();
            Employee model = db.Employee.Find(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Employee.Update(model);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Employee model = db.Employee.Find(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int employeeID)
        {
            try
            {
                Employee model = db.Employee.Find(employeeID);
                db.Employee.Remove(model);
                db.SaveChanges();
                TempData["Message"] = "Emplyee deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
