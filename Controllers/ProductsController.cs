using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCraze.Controllers
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Know the how MVC works with controllers Actions and routing
            Created Date : 22 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 22 - July - 2025
            Changed By   : Kiran Kumar
            JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-2
      *****************************************************************************************************/
    /*
    * Controller       : It is Brain of MVC that receives the requests from url and invokes specific controller 
    *                       Action Method and display the content to view
    *                       It Handles the requests and returns VIEW / JSON / REDIRECT etc
    * Action           : Method Inside the Controller to execute the Logic
    * Routing          : Decides which controller/Action runs for a given URL 
    *                    Mapping Between Controllers Actions defined in Route.Config
    */

    /*
     * In this example will know how controller is created and action method getting executed for the URL
     * Route - Products / List
     * URL : http://localhost:80/Products/List - Need to configure the default route in routing.config file
     */
    public class ProductsController : Controller
    {

        public ActionResult List()
        {
            ViewBag.Message = "Products List Page";
            return View();
        }
    }
}
