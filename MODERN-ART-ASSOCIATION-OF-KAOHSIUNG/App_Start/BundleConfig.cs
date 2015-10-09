using System.Web;
using System.Web.Optimization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Dictionary/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Dictionary/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Dictionary/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Dictionary/bootstrap.js",
                      "~/Scripts/Dictionary/respond.js",
                      "~/Scripts/Shared/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Dictionary/bootstrap.css",
                      "~/Content/Dictionary/site.css",
                      "~/Content/Shared/main.css",
                      "~/Content/Dictionary/font-awesome.css"));
        }
    }
}
