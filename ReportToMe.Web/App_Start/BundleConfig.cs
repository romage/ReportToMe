using System.Web;
using System.Web.Optimization;

namespace ReportToMe.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles
                .Add(new ScriptBundle("~/bundles/Libs/bootstrap")
                    .Include(
                        "~/Scripts/Libs/bootstrap.js"
                    )
                );
 
            bundles
                .Add(new ScriptBundle("~/bundles/Libs/angular.js")
                   .Include(
                        "~/Scripts/Libs/angular.js",
                        "~/Scripts/Libs/angular-route.js",
                        "~/Scripts/Libs/angular-resource.js",
                        "~/Scripts/Libs/ui-bootstrap-tpls-0.12.0.js"
                    )
                );

            bundles
                .Add(new ScriptBundle("~/bundles/jquery")
                        .Include(
                            "~/Scripts/Libs/jquery-1.10.2.js"
                        )
                    );
 
            bundles
                .Add(
                    new ScriptBundle("~/bundles/appCode")
                        .Include(
                            "~/Scripts/App/Extensions.js",
                            "~/Scripts/App/Application.js",
                            "~/Scripts/App/*.js"
                        )
                    );

            bundles
                .Add(new ScriptBundle("~/bundles/modernizr")
                    .Include(
                        "~/Scripts/Libs/modernizr-2.6.2.js"
                    )
                );

            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"
                        )
                    );
        }
    }
}
