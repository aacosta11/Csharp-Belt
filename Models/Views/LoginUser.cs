using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_Belt.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "enter a valid email")]
        [Display(Name = "Email: ")]      
        public string LogEmail {get;set;}                   // email

        [Required(ErrorMessage = "enter a valid password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LogPassword {get;set;}                // password
    }
}