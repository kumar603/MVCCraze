using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCraze.Filters
{
    /*****************************************************************************************************
        Writer       : Kiran Kumar J
        Description  : Authorization Filter — Session-based login check
        Created Date : 29 - July - 2025
        Created By   : Kiran Kumar
        Changed Date : 29 - July - 2025
        Changed By   : Kiran Kumar
        JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-5
  *****************************************************************************************************/
    /*
     * Important keywords or logic statements
     * AuthorizeAttribute - An attribute in ASP.NET MVC and Core used to restrict access to controllers 
     *                      or actions based on user authentication and roles/users. Inherits from FilterAttribute and implements IAuthorizationFilter.
     *                      
     * AuthorizeCore method -   A protected virtual method in AuthorizeAttribute. It receives an HttpContextBase object and 
     *                                returns a boolean indicating whether the current   user is authorized. Override this for custom authorization logic.
     * HttpContextBase  -   An abstract base class encapsulating all HTTP-specific information about an individual HTTP request. 
     *                      Provides access to Request, Response, User, Session, etc.
     *                           
     * HandleUnauthorizedRequest -  A protected virtual method in AuthorizeAttribute. Called when authorization fails; 
     *                              receives an AuthorizationContext and allows you to customize the response (e.g., return 401 or redirect).
     * AuthorizationContext  -  A context object passed to authorization filters like AuthorizeAttribute. 
     *                          Contains information about the current HTTP request, controller, action, 
     *                          and allows you to manipulate the response (Result property).
     */
    public class CustomAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["User"] != null;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                { "controller", "Home" },
                { "action", "Login" }
                });
        }
    }
}