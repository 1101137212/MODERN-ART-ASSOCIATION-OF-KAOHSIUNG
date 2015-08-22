using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BACKEND.Member
{
    public class MemberController : Controller
    {
        private Models.Member m = new Models.Member();

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