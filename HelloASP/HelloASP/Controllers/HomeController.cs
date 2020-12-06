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
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet("about")]
        public string About()
        {
            return "This is the about page";
        }

        [HttpGet("users/{username}")]
        public string Username(string username)
        {
            return $"whats up {username}?";
        }


    }
}
