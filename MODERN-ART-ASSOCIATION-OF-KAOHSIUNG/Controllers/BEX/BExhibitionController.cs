using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BEX
{
    public partial class BEXController : Controller
    {
        public string GetExhibitiondata_B()
        {
            return BEXModel.GetExhibition_B();
        }

        public void CreateExhibitiondata_B(Exhibition objPara)
        {
            BEXModel.CreateExhibition_B(objPara);
        }

        public void DeleteExhibitiondata_B(Exhibition objPara)
        {
            BEXModel.DeleteExhibition_B(objPara);
        }

        public void UpdateExhibitiondata_B(Exhibition objPara)
        {
            BEXModel.UpdateExhibition_B(objPara);
        }
    }
}