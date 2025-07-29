using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCraze.Controllers
{
    /*****************************************************************************************************
     Writer       : Kiran Kumar J
     Description  : Forms Authentication , Create AccountController with Login/Logout
     Created Date : 29 - July - 2025
     Created By   : Kiran Kumar
     Changed Date : 29 - July - 2025
     Changed By   : Kiran Kumar
     JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-8  
    *****************************************************************************************************/
    /*
     * Important keywords or logic statements
     * [AllowAnonymous]  :  
     * FormsAuthentication :  FormsAuthentication.SetAuthCookie , FormsAuthentication.SignOut();
     * RedirectToAction :  
     */
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(string username,string password)
        {
            if(username == "admin" || password == "admin123") 
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}