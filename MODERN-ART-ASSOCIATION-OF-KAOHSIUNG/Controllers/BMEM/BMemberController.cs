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
            return BMEMModel.GetMember_B();
        }

        public void CreateMemberdata_B(Member objPara)
        {
            BMEMModel.CreateMember_B(objPara);
        }

        public void DeleteMemberdata_B(Member objPara)
        {
            BMEMModel.DeleteMember_B(objPara);
        }

        public void UpdateMemberdata_B(Member objPara)
        {
            BMEMModel.UpdateMember_B(objPara);
        }
    }
}