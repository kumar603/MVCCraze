using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace MVCraze.Controllers
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Know the setup of an http://ASP.NET  MVC project, project structure, 
                            And how the MVC design pattern is practically applied.
            Created Date : 22 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 22 - July - 2025
            Changed By   : Kiran Kumar
      *****************************************************************************************************/
        //MVC           : MVC (Model-View-Controller) is a design pattern that separates concerns:
        //Model         : Business logic and data , Views , View Models 
        //View          : User interface CSHTML , Razor Views , HTML Helpers
        //Controller    : Request handling and application flow Request from routing
        //Project Configurations : Template MVC , References MVC and WebAPI , Authentication : None , Advanced : HTTP
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}