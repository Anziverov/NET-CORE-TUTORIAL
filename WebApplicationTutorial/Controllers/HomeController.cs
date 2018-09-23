using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTutorial.Models;
using WebApplicationTutorial.Util;

namespace WebApplicationTutorial.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;
        public HomeController(MobileContext context)
        {
            db = context;
        }

        #region partial view
        public ActionResult GetMessage()
        {
            return PartialView("_GetMessage");
        }
        #endregion

        public HtmlResult GetHtml()
        {
            return new HtmlResult("<h2>Привет ASP.NET Core</h2>");
        }
        public JsonResult GetUser()
        {
            User user = new User { Name = "Tom", Age = 29 };
            return Json(user);
        }
        public IActionResult Square(int altitude, int height)
        {
            double square = altitude * height / 2;
            return Content($"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}");
        }
        public IActionResult ListOfPhones()
        {
            return View(db.Phones.ToList());
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            ViewBag.Order = order;
            db.Orders.Add(order);
             db.SaveChanges();
            return View("Success");

        }
    }
}
