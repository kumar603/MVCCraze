using System.Web;
using System.Web.Optimization;

namespace MVCraze
{
    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  : Bundle Minification of the files to optimize the code
      Created Date : 29 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 29 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-7
*****************************************************************************************************/
    /*
     * Important keywords or logic statements
     * Bundling  : Combines multiple files into one file
     * Minification : Reduces file size by removing unnecessary character 
     * ISystem.Web.Optimization : Enables bundling/minification in ASP.NET Core, an open-source web development framework | .NET  MVC
     *  BundleConfig.cs : RegisterBundles(BundleCollection bundles) ,bundles.Add(new StyleBundle("~/Content/css").Include
     *                    bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
     *                    bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
     *                    BundleTable.EnableOptimizations = true;
     */
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
