using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomDisplay.Models;

namespace CustomDisplay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {

            var products = Products.GetProducts();
            return View(products);
        }


        public ActionResult Details()
        {
            return View();
        }
    }
}