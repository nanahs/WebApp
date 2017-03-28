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

        public CreateController(IConfigurationRoot conf)
        {
            config = conf;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult University()
        {

            return View();
        }

        public IActionResult Event()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeUniversity(WebUniversity uni)
        {

            //Insert new info into University Table, Description Table, and the Location Table
            var sProc = "makeUniversity";
            var s = config.GetConnectionString("MySqlDatabase");

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("name", uni.name);
            parameters.Add("abbrev", uni.abbrev);
            parameters.Add("numStud", uni.numStud);
            parameters.Add("descr", uni.desc);
            parameters.Add("loc", uni.loc);
            parameters.Add("lati", uni.lati);
            parameters.Add("longi", uni.longi);


            using (var con = new MySqlConnection(s))
            {
                con.Execute(sProc, parameters, commandTimeout: 120, commandType: System.Data.CommandType.StoredProcedure);
            }

            return Ok();
        }
    }
}
