using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public class BMemberController : Controller
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