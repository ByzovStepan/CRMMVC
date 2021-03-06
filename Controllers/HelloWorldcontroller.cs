﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Numtimes"] = NumTimes;

            return View();
        }
    }
}