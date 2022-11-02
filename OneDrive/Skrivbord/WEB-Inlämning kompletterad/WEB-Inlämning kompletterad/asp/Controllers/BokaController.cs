using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{

    public class BokaController : Controller
    {


        public IActionResult Index()
        {
            Bokning b = new Bokning();
            return View(b);
        }

        
        [HttpPost]
        public IActionResult Index(Bokning nybokning)
        {
                using (Databas db = new Databas()){
                db.Bokningar.Add(nybokning);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }


    }
}