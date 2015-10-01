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

        public void CreateExhibitiondata_B(Exhibition Exhibition)
        {
            BEXModel.CreateExhibition_B(Exhibition);
        }

        public void DeleteExhibitiondata_B(int Exhibition_ID)
        {
            BEXModel.DeleteExhibition_B(Exhibition_ID);
        }

        public void UpdateExhibitiondata_B(Exhibition Exhibition)
        {
            BEXModel.UpdateExhibition_B(Exhibition);
        }
    }
}