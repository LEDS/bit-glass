﻿using System.Web.Mvc;
using bitGlass.Models.Pessoas;

namespace bitGlass.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}