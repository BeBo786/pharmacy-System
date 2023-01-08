using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Test
{
    internal class Validitor
    {
        [Required(ErrorMessage = "Name Required")]
        public string FRIST_name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Enter valid Email")]
        public string User_email { get; set;}


        [Required(ErrorMessage = "Password is Required")]

        public string User_password { get; set;}

        [RegularExpression("^(01)*[0-9]{11}$", ErrorMessage = "Enter valid Phone")]
        [Required(ErrorMessage = "Phone number is Required")]
        public string User_phone { get; set;}
        

    }
}
