using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{
   
    public class HomeController : Controller
    {
        Databas db = new Databas();
        public IActionResult Index()
        {
            return View();
        }
    }
}
