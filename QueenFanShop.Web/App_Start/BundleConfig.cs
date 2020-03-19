using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace QueenFanShop.Web
{
     public class BundleConfig
     {
          public static void RegisterBundle(BundleCollection bundles)
          {
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Scripts/bootstrap.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                     "~/Scripts/jquery-3.4.1.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrapbundle/js").Include(
                     "~/Scripts/bootstrap.bundle.min.js"));
               bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                   "~/Content/style.css", new CssRewriteUrlTransform()));
            //      bundles.Add(new StyleBundle("~/bundles/style/css").Include(
            //         "~/Content/login.css", new CssRewriteUrlTransform()));

         //     bundles.Add(new StyleBundle("~/bundles/style/css").Include(
           //     "~/Content/contacts.css", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapbundle/js").Include(
                   "~/Scripts/contacts.js"));

        }
    }
}