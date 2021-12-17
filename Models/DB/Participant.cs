using System.ComponentModel.DataAnnotations;
using System;

namespace Csharp_Belt.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId {get;set;}

        /* ---------------------------------- user ---------------------------------- */
        public int UserId {get;set;}
        public User UserAsParticipant {get;set;}

        /* -------------------------------- activity -------------------------------- */
        public int ActivityId {get;set;}
        public Activity ActivityOfParticipant {get;set;}
        
        /* ------------------------------- timestamps ------------------------------- */
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}