using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientSideValidationInMVC.Models;
namespace ClientSideValidationInMVC.Controllers
{
    public class EmployeeRegFormController : Controller
    {
        // GET: EmployeeRegForm
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Emp model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
                ViewBag.Password = model.Password;
                ViewBag.Address = model.Address;
                ViewBag.Age = model.Age;

            }
            return View(model);
        }
    }
}