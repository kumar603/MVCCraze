using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCraze.Filters
{
    /*****************************************************************************************************
       Writer       : Kiran Kumar J
       Description  : Exception Filter — Global error catcher
       Created Date : 29 - July - 2025
       Created By   : Kiran Kumar
       Changed Date : 29 - July - 2025
       Changed By   : Kiran Kumar
       JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-5
 *****************************************************************************************************/
    /*
     * Important keywords or logic statements
     *FilterAttribute : 	The base attribute class from which all MVC filters derive. 
     *                      It provides shared properties such as Order and AllowMultiple and is used to mark filter classes.
     * IExceptionFilter	: An interface for creating exception filters. Implement this to handle unhandled exceptions globally 
     *                    or per-controller/action by defining custom logic in OnException.
     *                    
     * OnException	: The method defined by IExceptionFilter (and overridable in controllers) that receives an ExceptionContext parameter. 
     *              Called when an unhandled exception occurs. You use this to handle/log exceptions, set ExceptionHandled=true, and modify the response.
     * ExceptionContext	: A context object passed into OnException. Inherits from ControllerContext and holds detailed information 
     *                   about the thrown exception (Exception, ExceptionHandled), HTTP context, route data, controller, and allows setting the response (Result)
     */
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            Debug.WriteLine($"[ERROR] {ex.Message}");

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
    }
}