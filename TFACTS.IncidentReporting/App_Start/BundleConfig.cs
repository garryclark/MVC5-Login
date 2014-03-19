using System.Web;
using System.Web.Optimization;

namespace TFACTS.IncidentReporting
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Allow the use of CDN
            bundles.UseCdn = true;

            #region Scripts

            bundles.Add(new ScriptBundle("~/bundles/jquery", "http://code.jquery.com/jquery-1.11.0.min.js").Include(
                        "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval", "http://ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.js").Include(
                        "~/Scripts/jquery.validate*"));
            
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));       

            //Telerik CDN Kendo References
            bundles.Add(new ScriptBundle("~/bundles/telerikKendo", "http://cdn.kendostatic.com/2013.3.1324/js/kendo.all.min.js"));
   
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            //Custom scripts
            bundles.Add(new ScriptBundle("~/bundles/customScripts").Include(
                        "~/Scripts/custom/themeswitcher.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/respond").Include(
                      "~/Scripts/respond.js"));

            #endregion

            #region Styles

            bundles.Add(new StyleBundle("~/Content/customCSS").Include(
                      "~/Content/css/site.css",
                      "~/Content/css/login.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrapCSS", "//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css"));

            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}
