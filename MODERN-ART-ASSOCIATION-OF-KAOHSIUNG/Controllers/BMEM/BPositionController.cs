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
        public IList<Position> GetPositiondata_B()
        {
            return BPModel.GetPosition_B();
        }

        public void CreatePositiondata_B(Position objPara)
        {
            BPModel.CreatePosition_B(objPara);
        }

        public void DeletePositiondata_B(Position objPara)
        {
            BPModel.DeletePosition_B(objPara);
        }

        public void UpdatePositiondata_B(Position objPara)
        {
            BPModel.UpdatePosition_B(objPara);
        }
    }
}