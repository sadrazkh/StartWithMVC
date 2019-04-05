using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsInDetail.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string[] fruits = { "apple", "orange", "pear" };
            return View(fruits);
        }

        public ActionResult MyAction()
        {
            string[] fruits = { "apple", "orange", "pear" };
            return View(fruits);
        }
    }
}