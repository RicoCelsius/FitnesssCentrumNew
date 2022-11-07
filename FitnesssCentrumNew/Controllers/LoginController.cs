using FitnesssCentrumNew.Models;
using FitnesssCentrumNew;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FitnesssCentrumNew.Controllers
{
    public class LoginController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserReg ur)
        {


            if (ModelState.IsValid)
            {
                DAL.dbconnection connection = new DAL.dbconnection();
                connection.query($"select Email,Password FROM employee where Email='{ur.Email}' and Password={ur.Password}");

                return View();
            
            
            
            }

            return View();


        }






    }
}
