using MVCraze.Filters;
using MVCraze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCraze.Controllers
{
    /*****************************************************************************************************
          Writer       : Kiran Kumar J
          Description  : Logic to read the registration form data and validate user information 
                            and save data to the database server
          Created Date : 29 - July - 2025
          Created By   : Kiran Kumar
          Changed Date : 29 - July - 2025
          Changed By   : Kiran Kumar
          JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-4
    *****************************************************************************************************/
    /*
     * Important keywords or logic statements
     * ModelState.IsValid - Validates if the form submitted matches the criteria of model data annotations
     * RedirectToAction - If form is validated redirects to the another form else it will display the message
     * Return View - if form is not validated then it returns the same model of student along with required fields
     * [Authorize] -  Protect Controllers or Actions 
     */
    [LogActionFilter]
    [CustomAuthorize] //This ensures that if Session["User"] is not set, the user is redirected to Home/Login.
    [Authorize]
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                // Save to DB logic
                return RedirectToAction("Success");
            }
            return View(student);
        }
    }
}