﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult About()
		{
			return View();
		}
		public ActionResult News()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}
		public ActionResult Shop()
		{
			return View();
		}
		public ActionResult Cart()
		{
			return View();
		}
		public ActionResult Login()
		{
			return View();
		}
		public ActionResult CustomerRegister()
		{
			return View();
		}


	}
}