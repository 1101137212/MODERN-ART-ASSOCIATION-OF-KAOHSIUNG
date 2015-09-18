using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BMEM
{
    public partial class BMEMController : Controller
    {
        public string GetMemberdata_B()
        {
            return MEM.GetMember();
        }

        public void CreateMemberdata_B(Member Member)
        {
            MEM.CreateMember_B(Member);
        }

        public void DeleteMemberdata_B(int Member_ID)
        {
            MEM.DeleteMember_B(Member_ID);
        }

        public void UpdateMemberdata_B(Member Member)
        {
            MEM.UpdateMember_B(Member);
        }
    }
}