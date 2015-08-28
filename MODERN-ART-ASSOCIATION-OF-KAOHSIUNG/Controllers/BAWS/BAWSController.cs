using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        private BArtisticworksModel AWS = new BArtisticworksModel();

        public void CreateArtisticworksdata_B(Artisticworks Artisticworks)
        {
            AWS.CreateArtisticworks_B(Artisticworks);
        }

        public void DeleteArtisticworksdata_B(int Artisticworks_ID)
        {
            AWS.DeleteArtisticworks_B(Artisticworks_ID);
        }

        // GET: Artisticworks
        public ActionResult ArtisticworksIndex()
        {
            return View();
        }

        public void UpdateArtisticworksdata_B(Artisticworks Artisticworks)
        {
            AWS.UpdateArtisticworks_B(Artisticworks);
        }

        public string GetArtisticworksdata_B()
        {
            return AWS.GetArtisticworks_B();
        }
    }
}