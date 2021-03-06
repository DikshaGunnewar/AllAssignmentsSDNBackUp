﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Rakhi07AugAdminLte.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {         


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/DataTables/jquery.dataTables.min.js",
                       "~/Scripts/jquery.unobtrusive - ajax.js"
                       ));






            //add Admin Lte js
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/app.js"));

            //admin lte plugins fastclick liabrary
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/app.js"));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/app.js",
             "~/admin-lte/plugins/fastclick/fastclick.js",
              "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"
             ));










            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

           //css  //changed for admin Lte by diksha
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                     "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));
        }
    }
}