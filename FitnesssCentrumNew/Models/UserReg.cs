using System.ComponentModel.DataAnnotations;

namespace FitnesssCentrumNew.Models {

    public class UserReg
    {

        [Key]
        public int userId { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter an password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}