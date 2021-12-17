using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Csharp_Belt.Models;
using System.Linq;
using System;
namespace Csharp_Belt.Controllers
{
    public class HomeController : SessionController
    {
        private Context _ctx {get;}
        public HomeController(Context ctx) {_ctx = ctx;}

        /* ----------------------------- list activities ---------------------------- */
        [HttpGet("home/{userID}")]
        public IActionResult Home(int userID)
        {
            if (UserIsNotLoggedIn(userID)) return Redirect("/login");
            User disUser = _ctx.Users
                .Include(dis=>dis.ActivitiesParticipatingIn)
                    .ThenInclude(dis=>dis.ActivityOfParticipant)
                    .ThenInclude(dis=>dis.ActivityOwner)
                .Include(dis=>dis.AllActivities)
                    .ThenInclude(dis=>dis.ActivityParticipants)
                .FirstOrDefault(dis=>dis.UserId==userID);
            disUser.AllActivities = _ctx.Activities
                .Include(dis=>dis.ActivityOwner)
                .Include(dis=>dis.ActivityParticipants)
                .OrderByDescending(dis=>dis.CreatedAt)
                .ToList();
            return View("Home",disUser);
        }
    }
}