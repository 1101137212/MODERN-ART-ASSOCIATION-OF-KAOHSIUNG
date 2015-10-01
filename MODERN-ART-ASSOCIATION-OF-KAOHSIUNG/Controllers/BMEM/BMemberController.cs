﻿using System;
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
            return BMEMModel.GetMember();
        }

        public void CreateMemberdata_B(Member Member)
        {
            BMEMModel.CreateMember_B(Member);
        }

        public void DeleteMemberdata_B(int Member_ID)
        {
            BMEMModel.DeleteMember_B(Member_ID);
        }

        public void UpdateMemberdata_B(Member Member)
        {
            BMEMModel.UpdateMember_B(Member);
        }
    }
}