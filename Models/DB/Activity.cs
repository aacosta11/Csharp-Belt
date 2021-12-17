using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using CustomAttributes.Validators.Models;
using System;
namespace Csharp_Belt.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId {get;set;}
        /* ---------------------------- name of activity ---------------------------- */
        [Required(ErrorMessage = "Please enter a name for the activity")]
        [Display(Name = "Name of Activity: ")]
        public string ActivityName {get;set;}
        /* ------------------------ date and time of activity ----------------------- */
        [Required(ErrorMessage = "Enter a valid date")]
        [LaterThanToday(ErrorMessage = "Must be a date later than today!")]
        [Display(Name = "Date and Time: ")]
        public DateTime DateAndTime {get;set;}
        /* -------------------------------- duration -------------------------------- */
        [Required(ErrorMessage = "Enter a valid duration")]
        [Display(Name = "Duration: ")]
        [Range(1,9999,ErrorMessage = "Invalid duration.")]
        public int Duration {get;set;}
        [Required(ErrorMessage = "Select a valid time unit!")]
        public string timeUnit {get;set;}
        /* ------------------------------- description ------------------------------ */
        [Display(Name = "Description: ")]
        [Required(ErrorMessage = "Please provide a brief description")]
        public string Description {get;set;}
    
        /* ------------------------------- timestamps ------------------------------- */
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        /* --------------------------------- foreign -------------------------------- */
        public int UserId {get;set;}
        public User ActivityOwner {get;set;}
        public List<Participant> ActivityParticipants {get;set;}
        [NotMapped]
        public int TempUserId {get;set;}
    }
}