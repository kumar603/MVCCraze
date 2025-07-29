using MVCraze.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVCraze
{
    /*****************************************************************************************************
       Writer       : Kiran Kumar J
       Description  : Exception Filter — Register Global Filters with CustomExceptionFilter 
       Created Date : 29 - July - 2025
       Created By   : Kiran Kumar
       Changed Date : 29 - July - 2025
       Changed By   : Kiran Kumar
       JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-5
 *****************************************************************************************************/
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
        }
    }
}
