﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning.SignalR.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult ChatHall()
        {
            return View();
        }

		public ActionResult Register()
		{
			return View();
		}
	}
}