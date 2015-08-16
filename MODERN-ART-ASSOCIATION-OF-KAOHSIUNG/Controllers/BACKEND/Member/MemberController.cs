using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BACKEND.Member
{
    public class MemberController : Controller
    {
        Models.Member m = new Models.Member();
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        public string GetMemberdata()
        {
            return m.GetMember();
        }
    }
}