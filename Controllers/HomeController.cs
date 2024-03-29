﻿using BiebCWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace BiebCWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        // new views added:
        public IActionResult Log()
        {
            return View();
        }
        public IActionResult Bieb()
        {
            return View();
        }
 
        // end new views

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}