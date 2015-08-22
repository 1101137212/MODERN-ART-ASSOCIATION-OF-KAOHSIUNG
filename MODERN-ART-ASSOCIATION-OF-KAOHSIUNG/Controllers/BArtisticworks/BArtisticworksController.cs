using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BArtisticworksController : Controller
    {
        private Models.Backstage.BArtisticworksModel c = new Models.Backstage.BArtisticworksModel();

        public void CreateArtisticwork(Artisticworks Artisticworks)
        {
            c.Create(Artisticworks);
        }

        public void DeleteArtisticwork(int Artisticworks_ID)
        {
            c.Delete(Artisticworks_ID);
        }

        // GET: Artisticworks
        public ActionResult Index()
        {
            return View();
        }

        public void UpdateArtisticwork(Artisticworks Artisticworks)
        {
            c.Update(Artisticworks);
        }

        //public string Getdata()
        //{
        //    return c.GetArtisticworks();

        //}
        //[HttpGet]
        //public ActionResult GetData()
        //{
        //    return c.GetArtisticworks();
        //}

        //public JsonResult Index1()
        //{
        //    IEnumerable<System.Data.DataRow> Artisticworks = from row in c.GetArtisticworks() select row;
        //    ViewBag.table = Artisticworks;
        //    return Json(Artisticworks, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult Index2()
        //{
        //    List<Models.Artisticworks> Artisticworks = Models.Artisticworksdata.GetArtisticworks();
        //    return Json(Artisticworks,JsonRequestBehavior.AllowGet);
        //}
    }
}