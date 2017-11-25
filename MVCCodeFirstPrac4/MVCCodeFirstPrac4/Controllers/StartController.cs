using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCodeFirstPrac4.Models;

namespace MVCCodeFirstPrac4.Controllers
{
    public class StartController : Controller
    {
        // GET: Start
        public ActionResult Index()
        {
            Customers cust = new Customers();

            return View(cust);
        }
    }
}