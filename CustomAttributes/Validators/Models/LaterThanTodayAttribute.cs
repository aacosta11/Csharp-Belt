using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;
namespace CustomAttributes.Validators.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    sealed public class LaterThanTodayAttribute : ValidationAttribute // date must be later than the current date
    {
        public override bool IsValid(object value)
        {
            return DateTime.Compare(DateTime.Now,(DateTime)value) < 0;
        }
        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
        }
    }
}