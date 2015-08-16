using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class ArtisticworksController : Controller
    {
        Models.Artisticworksdata c = new Models.Artisticworksdata();
        // GET: Artisticworks
        public ActionResult Index()
        {

            return View();

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