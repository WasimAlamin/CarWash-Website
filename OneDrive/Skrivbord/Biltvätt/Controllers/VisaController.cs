using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{    
    
    public class VisaController : Controller
    {   
        public IActionResult Index()
        {
            using (Databas db = new Databas())
            {

               List<Bokning> Bokninglista = db.Bokningar.ToList();
                return View(Bokninglista);
               

            }
        }
    }
}
