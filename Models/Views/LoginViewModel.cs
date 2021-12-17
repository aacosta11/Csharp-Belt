using System.ComponentModel.DataAnnotations;

namespace Csharp_Belt.Models
{
    public class LoginViewModel 
    {
        public User User {get;set;} = new User();
        public LoginUser LoginUser {get;set;} = new LoginUser();
    }
}