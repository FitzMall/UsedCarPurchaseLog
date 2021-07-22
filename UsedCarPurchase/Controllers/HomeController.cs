using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsedCarPurchase.BizObjects;
using UsedCarPurchase.DAL;
using UsedCarPurchase.Helpers;
using UsedCarPurchase.Models;

namespace UsedCarPurchase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

    }
}