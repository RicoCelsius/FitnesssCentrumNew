using FitnesssCentrumNew.Models;
using FitnesssCentrumNew;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

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
        public IActionResult Create(UserReg ur)
        {

            DAL.dbconnection f = new DAL.dbconnection();
            string sqlquery = "insert into employee(Email,Password) values('"+ur.Email+"','"+ur.Password+"')";
            f.query(sqlquery);
            return View(ur);
        }

    }
}
