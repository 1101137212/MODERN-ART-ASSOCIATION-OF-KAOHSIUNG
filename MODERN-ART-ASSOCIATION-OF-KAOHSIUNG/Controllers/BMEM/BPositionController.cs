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
            return BPModel.GetPosition_B();
        }

        public void CreatePositiondata_B(Position Position)
        {
            BPModel.CreatePosition_B(Position);
        }

        public void DeletePositiondata_B(int Position_ID)
        {
            BPModel.DeletePosition_B(Position_ID);
        }

        public void UpdatePositiondata_B(Position Position)
        {
            BPModel.UpdatePosition_B(Position);
        }
    }
}