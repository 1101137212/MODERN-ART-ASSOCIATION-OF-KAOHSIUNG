using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        private BArtisticworksModel BAWSModel = new BArtisticworksModel();

        // GET: Artisticworks
        public ActionResult ArtisticworksIndex()
        {
            return View();
        }

        public void CreateArtisticworksdata_B(Artisticworks objPara)
        {
            BAWSModel.CreateArtisticworks_B(objPara);
        }

        public void DeleteArtisticworksdata_B(Artisticworks objPara)
        {
            BAWSModel.DeleteArtisticworks_B(objPara);
        }             

        public void UpdateArtisticworksdata_B(Artisticworks objPara)
        {
            BAWSModel.UpdateArtisticworks_B(objPara);
        }

        public IList<Artisticworks> GetArtisticworksdata_B()
        {
            return BAWSModel.GetArtisticworks_B();
        }
    }
}