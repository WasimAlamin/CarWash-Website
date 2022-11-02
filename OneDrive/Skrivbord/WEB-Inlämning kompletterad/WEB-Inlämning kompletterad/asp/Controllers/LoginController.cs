using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
       
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync (login user) 
        {
           bool userok =kontroll(user);
            if (userok == true)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Användarnamn));

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                return RedirectToAction("Index", "Visa");
                
            }
            else 
            {
                return View();
            }
           
        }

        public bool kontroll (login user) 
        {

            if (user.Användarnamn == "admin" && user.Lösenord == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}
