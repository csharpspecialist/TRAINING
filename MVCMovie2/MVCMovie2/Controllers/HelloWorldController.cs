﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Index()
        {
            return View();
        }



        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public ActionResult Good()
        {
            
            return View();
        }


        public ActionResult Nice()
        {

            return View();
        }


    }
}