using FitnesssCentrumNew.Models;
using FitnesssCentrumNew;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Logic;

namespace FitnesssCentrumNew.Controllers
{
    public class RegistrationController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

  

        [HttpPost]
        public IActionResult Create(UserRegModel ur)
        {

            DAL.dbconnection f = new DAL.dbconnection(); //logica object aanmaken, dal object meegeven.
        
            string sqlquery = $"insert into employee(Email,Password) values({ur.Email},{ur.Password})";
            f.InsertUpdateDelete(sqlquery);
            return View(ur);
        }

    }
}
