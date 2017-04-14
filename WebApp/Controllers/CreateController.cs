using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using WebApp.Contexts;
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace WebApp.Controllers
{
    public class CreateController : Controller
    {

        private readonly IConfigurationRoot config;
        private MySqlContext context;

        public CreateController(IConfigurationRoot conf, MySqlContext cont)
        {
            config = conf;
            context = cont;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rso()
        {
            return View();
        }
        
        public IActionResult University()
        {

            return View();
        }

        public IActionResult Event()
        {
            
            return View(context.Categories.Distinct());
        }

        [HttpPost]
        public IActionResult MakeUniversity(WebUniversity uni)
        {

            //validate user

            //Insert new info into University Table, Description Table, and the Location Table
            var sProc = "makeUniversity";
            var s = config.GetConnectionString("MySqlDatabase");

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("name", uni.Name);
            parameters.Add("abbrev", uni.Abbrev);
            parameters.Add("numStud", uni.NumStud);
            parameters.Add("descr", uni.Descr);
            parameters.Add("loc", uni.Loc);
            parameters.Add("lati", uni.Lati);
            parameters.Add("longi", uni.Longi);


            using (var con = new MySqlConnection(s))
            {
                con.Execute(sProc, parameters, commandTimeout: 120, commandType: System.Data.CommandType.StoredProcedure);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult MakeEvent(WebEvent even)
        {
            var sProc = "makeEvent";
            var s = config.GetConnectionString("MySqlDatabase");

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("name", even.Name);
            parameters.Add("theDate", even.Dt);
            parameters.Add("loc", even.Loc);
            parameters.Add("catId", even.Cat);
            parameters.Add("descr", even.Descr);
            parameters.Add("phone", even.Phone);
            parameters.Add("email", even.Email);
            parameters.Add("ETypeId", even.EventTypeId);
            parameters.Add("lati", even.Lati);
            parameters.Add("longi", even.Longi);

            using (var con = new MySqlConnection(s))
            {
                con.Execute(sProc, parameters, commandTimeout: 120, commandType: System.Data.CommandType.StoredProcedure);
            }

            return Ok();
        }
    }
}
