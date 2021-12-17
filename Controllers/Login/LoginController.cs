using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Csharp_Belt.Models;
using System.Linq;
using System;

namespace Csharp_Belt.Controllers
{
    public class LoginController : SessionController
    {
        private Context _ctx {get;}
        public LoginController(Context ctx) {_ctx = ctx;}
        public PasswordHasher<User> RegHash {get;set;} = new PasswordHasher<User>();
        public PasswordHasher<LoginUser> LogHash {get;set;} = new PasswordHasher<LoginUser>();

        /* ------------------------- redirect to login page ------------------------- */
        [HttpGet("{*catch}")]
        public RedirectResult Redirect() => Redirect("/login");

        /* ------------------------------- LOGIN PAGE ------------------------------- */
        [HttpGet("login")] // login form
        public IActionResult LoginPage()
        {
            if (SomeoneIsLoggedIn())
            {
                int? userID = GetLoggedInUser();
                return Redirect($"/home/{userID}");
            }
            return View("Login");
        }
        /* ----------------------------- LOGIN REQUESTS ----------------------------- */
        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            if (!ModelState.IsValid) return View("Login");
            User disUser = _ctx.Users.FirstOrDefault(dis=>dis.Email==user.LogEmail);
            if (disUser == null) 
            {
                ModelState.AddModelError("LogEmail","Invalid Email/Password");
                return View("Login");
            }
            if (LogHash.VerifyHashedPassword(user,disUser.Password,user.LogPassword)==0)
            {
                ModelState.AddModelError("LogEmail","Invalid Email/Password");
                return View("Login");
            }
            LogUserIn(disUser.UserId);
            return Redirect($"/home/{disUser.UserId}");
        }
        [HttpPost("login/new")]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid) return View("Login");
            if (_ctx.Users.Any(dis=>dis.Email==user.Email))
            {
                ModelState.AddModelError("Email","Email is in use!");
                return View("Login");
            }
            user.Password = RegHash.HashPassword(user,user.Password);
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
            LogUserIn(user.UserId);
            return Redirect($"/home/{user.UserId}");
        }
        /* --------------------------------- logout --------------------------------- */
        [HttpGet("logout")] 
        public RedirectResult Logout()
        {
            LogUserOut();
            return Redirect("Login");
        }
    }
}