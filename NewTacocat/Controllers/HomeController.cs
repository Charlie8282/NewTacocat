using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewTacocat.Models;

namespace NewTacocat.Controllers
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

        public IActionResult TacoCat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TacoCat(string userWord)
        {
            ViewData["Result"] = string.Join("", userWord.Reverse().ToArray());
            return View().replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/]|\s/gi, '');
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
