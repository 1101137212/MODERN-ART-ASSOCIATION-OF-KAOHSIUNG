using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public class BMEMController : Controller
    {
        private BMemberModel MEM = new BMemberModel();

        public string GetMemberdata()
        {
            return MEM.GetMember();
        }

        // GET: Member
        public ActionResult MemberIndex()
        {
            return View();
        }

        //public string CreateMember()
        //{
        //}
    }
}