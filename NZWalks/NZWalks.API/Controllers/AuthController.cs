﻿using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
