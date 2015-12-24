using AattestationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AattestationSystem.Controllers
{
    public class TestJSController : Controller
    {
        // GET: TestJS
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Test1()
        {
            ViewBag.NextTestAction = "Test2";
            return View();
        }


        public ActionResult Test2()
        {
            ViewBag.PrevTestAction = "Test1";
            ViewBag.NextTestAction = "Test3";
            return View();
        }


        public ActionResult Test3()
        {
            ViewBag.PrevTestAction = "Test2";
            ViewBag.NextTestAction = "Test4";
            return View();
        }


        public ActionResult Test4()
        {
            //using(ApplicationDbContext db = new ApplicationDbContext())
            //{
            //}
            ViewBag.PrevTestAction = "Test3";
            ViewBag.NextTestAction = "Test5";
            return View();
        }
    }
}