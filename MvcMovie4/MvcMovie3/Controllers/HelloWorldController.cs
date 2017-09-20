using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie3.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Arcade()
        {
            return View();
        }

        public ActionResult Switch()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}