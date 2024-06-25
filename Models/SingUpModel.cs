using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Checker.Models
{
    public class SingUpModel
    {
        

        [Required]
        public string ?email { get; set; }
        [Required]
        public string ?password { get; set; }

        public SingUpModel(){

        }

        public SingUpModel(string _password){
            password = _password;
        }
    }
}