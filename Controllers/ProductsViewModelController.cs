using MVCraze.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCraze.Controllers
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Know  how to Build Dynamic Web pages using views sending data bw views through
                            controllers and View through viewModels and Bind data efficiently
            Created Date : 22 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 22 - July - 2025
            Changed By   : Kiran Kumar
            JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-3
      *****************************************************************************************************/
    /*
    * View(.cshtml)     : Generates html pages dynamically using c# in html
    *                     Seperation of UI from Logic(MVC Patteren)
    *                     Display Data with html helper tags
    * VideModels(.cs)   : A class that Contains data or View send by controller to view
    *                     Pure data structure
    */

    /*
     * In this example will know how to build dynamic pages views that loads the data binding from viewmodel 
     * Route - Products / Details
     * URL : http://localhost:80/ProductsViewModel/Details  
     */
    public class ProductsViewModelController : Controller
    {
        // GET: ProductsViewModel
        public ActionResult Details()
        {
            var products = new ProductsViewModel
            {
                Id = 1,
                Name="TV",
                Price=25000
            };
            return View(products);
        }
    }
}