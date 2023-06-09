﻿//using System.Web;
//using System.Web.Optimization;

//namespace MovieRentalV04
//{
//    public class BundleConfig
//    {
//        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
//        public static void RegisterBundles(BundleCollection bundles)
//        {
//            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
//                        "~/Scripts/jquery-{version}.js",
//                        "~/scripts/typeahead.bundle.js"






//                        ));

//            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
//                        "~/Scripts/jquery.validate*"));

//            // Use the development version of Modernizr to develop with and learn from. Then, when you're
//            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
//            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
//                        "~/Scripts/modernizr-*"));

//            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
//                      "~/Scripts/bootstrap.js",
//            "~/Scripts/bootstrap.js",
//            "~/Scripts/bootbox.js.js",

//                      "~/scripts/toastr.js",
//                      "~/Scripts/respond.js",
//                      "~/Scripts/DataTables/jquery.dataTables.js",
//                      "~/Scripts/DataTables/dataTables.bootstrap.js"));

//            bundles.Add(new StyleBundle("~/Content/css").Include(
//                      "~/Content/bootstrap-lumen.css",
//                      "~/content/datatables/css/datatables.bootstrap.css",
//                      "~/content/typeahead.css",
//                      "~/content/toastr.css",
//                      "~/Content/site.css"));
//        }
//    }
//}
using System.Web;

using System.Web.Optimization;




namespace MovieRentalV04

{

    public class BundleConfig

    {

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862

        public static void RegisterBundles(BundleCollection bundles)

        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(

                "~/Scripts/jquery-{version}.js",
                "~/Scripts/typeahead.bundle.js"));




            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(

                "~/Scripts/jquery.validate*"));




            // Use the development version of Modernizr to develop with and learn from. Then, when you're

            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(

                "~/Scripts/modernizr-*"));




            bundles.Add(new Bundle("~/bundles/bootstrap").Include(

                "~/Scripts/bootstrap.js",

                "~/Scripts/bootstrap.js",

                "~/Scripts/bootbox.js",

                "~/Scripts/respond.js",

                "~/Scripts/DataTables/jquery.dataTables.js",

                "~/Scripts/DataTables/dataTables.bootstrap.js",

                "~/Scripts/toastr.js"

               ));




            bundles.Add(new StyleBundle("~/Content/css").Include(

                "~/Content/bootstrap-lumen.css",

                "~/content/datatables/css/datatables.bootstrap.css",

                "~/content/typeahead.css",

                "~/content/toastr.css",

                "~/Content/Site.css"));

        }

    }

}