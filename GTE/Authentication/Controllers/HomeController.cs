﻿using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("register","auth");
        }
    }
}
