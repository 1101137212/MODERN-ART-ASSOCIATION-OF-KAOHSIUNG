using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BArtisticworksController : Controller
    {
        private BArtisticworksModel c = new BArtisticworksModel();

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

    }
}