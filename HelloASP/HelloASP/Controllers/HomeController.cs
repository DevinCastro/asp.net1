using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloASP.Models;

namespace HelloASP.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("about")]
        public ViewResult About()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpGet("users/{username}")]
        public IActionResult Username(string username)
        {
            return Json(new {user=username, text = "hello"});
        }


    }
}
