using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Csharp_Belt.Models;
using System.Linq;
using System;

namespace Csharp_Belt.Controllers
{
    public class ActivityModelController : SessionController
    {
        private Context _ctx {get;}
        public ActivityModelController(Context ctx) {_ctx = ctx;}

        /* ------------------------------ activity form ----------------------------- */
        [HttpGet("home/{userID}/new-activity")]
        public IActionResult ActivityForm(int userID)
        {
            if (UserIsNotLoggedIn(userID)) return Redirect("/login");

            DateTime DefaultT = DateTime.Now.AddHours(1);
            string Dstring = DefaultT.ToString("g");
            DefaultT = DateTime.Parse(Dstring);
            Activity newAct = new Activity()
            {
                DateAndTime = DefaultT
            };
            return View("ActivityForm",newAct);
        }
        /* ------------------------------ view activity ----------------------------- */
        [HttpGet("home/{userID}/activity/{actID}")]
        public IActionResult ActivityView(int userID, int actID)
        {
            if (UserIsNotLoggedIn(userID)) return Redirect("/login");
            Activity disAct = _ctx.Activities
                .Include(dis=>dis.ActivityOwner)
                .Include(dis=>dis.ActivityParticipants)
                    .ThenInclude(dis=>dis.UserAsParticipant)
                .FirstOrDefault(dis=>dis.ActivityId==actID);
            if (disAct==null) {return Redirect($"/home/{userID}");}
            disAct.ActivityParticipants = _ctx.Participants
                .Include(x=>x.UserAsParticipant)
                .Where(x=>x.ActivityId==actID)
                .ToList();
            disAct.TempUserId = userID;
            return View("ActivityView",disAct);
        }

        /* ------------------------------ add activity ------------------------------ */
        [HttpPost("home/{userID}/new-activity")]
        public IActionResult AddActivity(Activity act, int userID)
        {
            act.UserId = userID;
            if (!ModelState.IsValid) return View("ActivityForm");
            _ctx.Activities.Add(act);
            _ctx.SaveChanges();
            return Redirect($"/home/{userID}");
        }

        /* ----------------------------- delete activity ---------------------------- */
        [HttpGet("home/{userID}/delete-activity/{actID}")]
        public IActionResult DeleteActivity(int userID, int actID)
        {
            if (UserIsNotLoggedIn(userID)) return Redirect("/login");
            Activity disAct = _ctx.Activities.FirstOrDefault(dis=>dis.ActivityId==actID);
            if (disAct==null) {return Redirect($"/login");}
            _ctx.Activities.Remove(disAct);
            _ctx.SaveChanges();
            return Redirect($"/home/{userID}");
        }

    }
}