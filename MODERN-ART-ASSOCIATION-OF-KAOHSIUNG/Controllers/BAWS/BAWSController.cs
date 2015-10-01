using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        private BArtisticworksModel BAWSModel = new BArtisticworksModel();

        public void CreateArtisticworksdata_B(Artisticworks Artisticworks)
        {
            BAWSModel.CreateArtisticworks_B(Artisticworks);
        }

        public void DeleteArtisticworksdata_B(int Artisticworks_ID)
        {
            BAWSModel.DeleteArtisticworks_B(Artisticworks_ID);
        }

        // GET: Artisticworks
        public ActionResult ArtisticworksIndex()
        {
            return View();
        }

        public void UpdateArtisticworksdata_B(Artisticworks Artisticworks)
        {
            BAWSModel.UpdateArtisticworks_B(Artisticworks);
        }

        public string GetArtisticworksdata_B()
        {
            return BAWSModel.GetArtisticworks_B();
        }
    }
}