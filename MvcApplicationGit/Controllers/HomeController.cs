﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationGit.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string str = "Hello, This is for testing";
            return View(str);
        }
	public ActionResult Submit()

	{
	return View();
	} 

    }
}
