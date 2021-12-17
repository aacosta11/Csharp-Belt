using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_Belt.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;} // primary
        /* ------------------------------- PROPERTIES ------------------------------- */
        [Required(ErrorMessage = "name is required")]
        [MinLength(2,ErrorMessage = "should be at least 2 characters")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Name may only contain letters and spaces")]
        [Display(Name = "Name: ")]
        public string Name {get;set;}                                      // name


        [Required(ErrorMessage = "email is required")]
        [Display(Name = "Email: ")]
        [EmailAddress(ErrorMessage = "enter a valid email address!")]
        public string Email {get;set;}                                     // email

        [Required(ErrorMessage = "please enter a password")]
        // REGEX FOR :   1 letter 1 number 1 special
        [RegularExpression("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+])[A-Za-z\\d][A-Za-z\\d!@#$%^&*()_+]{7,19}$",
        ErrorMessage = "Passwords must be 8 chars, start with a letter, followed by at least 1 number and special character!")]
        [MinLength(8,ErrorMessage = "should be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password {get;set;}                                  // password

        [NotMapped]
        [Required(ErrorMessage = "please confirm pass")]
        [MinLength(6,ErrorMessage = "should be at least 6 characters")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "passwords don't match!")]
        [Display(Name = "Confirm: ")]
        public string ConfirmPassword {get;set;}                          // confirm pw

        public DateTime CreatedAt {get;set;} = DateTime.Now;              
        public DateTime UpdatedAt {get;set;} = DateTime.Now;              

        /* --------------------------------- FOREIGN -------------------------------- */
        public List<Participant> ActivitiesParticipatingIn {get;set;} = new List<Participant>(){};
        public List<Activity> AllActivities {get;set;} = new List<Activity>(){};
    }
}