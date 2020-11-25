using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skazochniki.Models;

namespace Skazochniki.Controllers
{
    public class HomeController : Controller
    {
        CourseContext CourseContext = new CourseContext();
        public ActionResult Index()
        {
            //извлекаем данные из тестовой таблицы 
            IEnumerable<Course> Course = CourseContext.Course;

            ViewBag.Course = Course;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.Id = Id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;

            CourseContext.Purchases.Add(purchase);

            CourseContext.SaveChanges();

            return $"sended";
        }
    }
}