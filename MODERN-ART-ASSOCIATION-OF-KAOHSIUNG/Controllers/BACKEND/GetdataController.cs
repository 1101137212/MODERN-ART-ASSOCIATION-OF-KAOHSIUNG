using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class ArtisticworksController : Controller
    {
        public string Getdata()
        {
            return c.GetArtisticworks();
        }
    }
}