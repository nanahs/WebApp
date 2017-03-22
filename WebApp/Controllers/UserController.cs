using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Contexts;
using WebApp.Models;
using WebApp.Repositories;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {

        private readonly MySqlContext cont;

        public UserController(MySqlContext context)
        {
            cont = context;
        }

        public async Task<IActionResult> Index()
        {

            List<User> users = cont.Users.ToList();

            return View(await cont.Users.ToListAsync());
        }

    }
}
