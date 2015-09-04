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
        public string GetPositiondata_B()
        {
            return P.GetPosition_B();
        }

        public void CreatePositiondata_B(Position Position)
        {
            P.CreatePosition_B(Position);
        }

        public void DeletePositiondata_B(int Position_ID)
        {
            P.DeletePosition_B(Position_ID);
        }

        public void UpdatePositiondata_B(Position Position)
        {
            P.UpdatePosition_B(Position);
        }
    }
}