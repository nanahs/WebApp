using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login log)
        {
            //Verify email/password combination

            //give cookie if login is valid?
            if (log.verifyLogin())
            {
                return View();
            }

            //return back to login page with error message
            return Index();



            

        }
    }
}
