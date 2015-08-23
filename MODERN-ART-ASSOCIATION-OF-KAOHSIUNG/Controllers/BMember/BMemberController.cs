using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public class BMemberController : Controller
    {
        private Models.Backstage.BMemberModel m = new Models.Backstage.BMemberModel();

        public string GetMemberdata()
        {
            return m.GetMember();
        }

        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        //public string CreateMember()
        //{
        //}
    }
}