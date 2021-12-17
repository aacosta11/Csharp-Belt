using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Csharp_Belt.Models;
using System.Linq;
using System;

namespace Csharp_Belt.Controllers
{
    public class ParticipantActionsController : SessionController
    {
        private Context _ctx {get;}
        public ParticipantActionsController(Context ctx) {_ctx = ctx;}

        [HttpGet("home/{userID}/add-participant/{actID}")]
        public IActionResult AddParticipant(int userID,int actID)
        {
            // if (UserIsNotLoggedIn(userID)) return Redirect("/login");
            if (_ctx.Participants.Any(dis=>dis.UserId==userID&&dis.ActivityId==actID))
            {
                return Redirect($"/home/{userID}");
            }            
            Participant prt = new Participant()
            {
                UserId = userID,
                ActivityId = actID
            };
            _ctx.Participants.Add(prt);
            _ctx.SaveChanges();
            return Redirect($"/home/{userID}");
        }
        
        [HttpGet("home/{userID}/un-add-participant/{actID}")]
        public IActionResult UnAddParticipant(int userID,int actID)
        {
            // if (UserIsNotLoggedIn(userID)) return Redirect("/login");
            Participant prt = _ctx.Participants.FirstOrDefault(dis=>dis.ActivityId==actID&&dis.UserId==userID);
            if (prt == null) {return Redirect($"/home/{userID}");}
            _ctx.Participants.Remove(prt);
            _ctx.SaveChanges();
            return Redirect($"/home/{userID}");
        }
    }
}