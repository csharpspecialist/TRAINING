using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirstDbase1.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Ronin()
        {
            int z = 10;
            if(z == 10)
            {
                return Redirect("~/First/Index");
            }
          
            return View();
        }


    }
}