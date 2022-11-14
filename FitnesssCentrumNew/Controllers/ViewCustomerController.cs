using FitnesssCentrumNew.Models;
using FitnesssCentrumNew;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace FitnesssCentrumNew.Controllers
{
    public class ViewCustomerController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Show(CustomerModel ur)
        {


            if (ModelState.IsValid)
            {
  

                return View();
            
            
            
            }

            return View();


        }






    }
}
