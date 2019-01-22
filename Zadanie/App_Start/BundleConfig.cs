using System.Web;
using System.Web.Optimization;

namespace Zadanie
{
    public class BundleConfig
    {
        // Aby uzyskać więcej informacji o grupowaniu, odwiedź stronę https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/my_scripts").Include(
            "~/Scripts/my_scripts.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));
            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Użyj wersji deweloperskiej biblioteki Modernizr do nauki i opracowywania rozwiązań. Następnie, kiedy wszystko będzie
            // gotowe do produkcji, użyj narzędzia do kompilowania ze strony https://modernizr.com, aby wybrać wyłącznie potrzebne testy.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui/css").Include(
  "~/Content/themes/base/core.css",
  "~/Content/themes/base/resizable.css",
  "~/Content/themes/base/selectable.css",
  "~/Content/themes/base/accordion.css",
  "~/Content/themes/base/autocomplete.css",
  "~/Content/themes/base/button.css",
  "~/Content/themes/base/dialog.css",
  "~/Content/themes/base/slider.css",
  "~/Content/themes/base/tabs.css",
  "~/Content/themes/base/datepicker.css",
  "~/Content/themes/base/progressbar.css",
  "~/Content/themes/base/theme.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Site.css"
                
                      ));
        }
    }
}
