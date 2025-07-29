using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCraze
{
    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  : Bundle Minification Registration in global file
      Created Date : 29 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 29 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-7
*****************************************************************************************************/
    /*
     * Important keywords or logic statements
     *  BundleConfig.RegisterBundles(BundleTable.Bundles); //Register the Bundles 
     */
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles); //Register the Bundles 
        }
    }
}
