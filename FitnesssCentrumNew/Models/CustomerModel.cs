using System.ComponentModel.DataAnnotations;

namespace FitnesssCentrumNew.Models {

    public class CustomerModel
    {

     
        public int userId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}