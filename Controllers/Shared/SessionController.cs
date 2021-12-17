using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Csharp_Belt.Controllers
{
    public class SessionController : Controller
    {
        /* -------------------------------------------------------------------------- */
        /*                                 validate id                                */
        /* -------------------------------------------------------------------------- */
        /* ------------------------------- compare ids ------------------------------ */
        /// <summary>Returns TRUE if the provided id does NOT MATCH session key "loginID".</summary>
        public bool UserIsNotLoggedIn (int userID) => HttpContext.Session.GetInt32("loginID") != userID;

        /* ------------------------------ contains id? ------------------------------ */
        /// <summary>Returns TRUE if session holds a UserId</summary>
        public bool SomeoneIsLoggedIn() => HttpContext.Session.GetInt32("loginID") != null;
        
        /* ------------------------------- log user in ------------------------------ */
        /// <summary>Returns VOID. Sets session key "loginID" with provided integer.</summary>
        public void LogUserIn(int userID) => HttpContext.Session.SetInt32("loginID",userID);

        /* ---------------------------- return session id --------------------------- */
        /// <summary>Returns INT? found in session key "loginID".</summary>
        public int? GetLoggedInUser() => HttpContext.Session.GetInt32("loginID");






        /* -------------------------------------------------------------------------- */
        /*                                   errors                                   */
        /* -------------------------------------------------------------------------- */
        /* ----------------------------- get First error ---------------------------- */
        /// <summary>Returns VOID. Sets session key "FirstError" with provided string.</summary>
        public void AddFirstError(string First) => HttpContext.Session.SetString("FirstError",First);
        /* ---------------------------- get First error --------------------------- */
        /// <summary>Return STRING from session key "FirstError".</summary>
        public string GetFirstError() => HttpContext.Session.GetString("FirstError");

        /* ---------------------------- add Second error --------------------------- */
        /// <summary>Returns VOID. Sets session key "SecondError" with provided string.</summary>
        public void AddSecondError(string Second) => HttpContext.Session.SetString("SecondError",Second);
        /* ---------------------------- get Second error --------------------------- */
        /// <summary>Return STRING from session key "SecondError".</summary>
        public string GetSecondError() => HttpContext.Session.GetString("SecondError");





        /* -------------------------------------------------------------------------- */
        /*                                   logout                                   */
        /* -------------------------------------------------------------------------- */
        /// <summary>Returns VOID. Clears session.</summary>
        public void LogUserOut() => HttpContext.Session.Clear();
    }
}