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
        public IList<ExhibitionRecord> GetExhibitionRecorddata_B()
        {
            return BEXRModel.GetExhibitionRecord_B();
        }

        public void CreateExhibitionRecorddata_B(ExhibitionRecord objPara)
        {
            BEXRModel.CreateExhibitionRecord_B(objPara);
        }

        public void DeleteExhibitionRecorddata_B(ExhibitionRecord objPara)
        {
            BEXRModel.DeleteExhibitionRecord_B(objPara);
        }

        public void UpdateExhibitionRecorddata_B(ExhibitionRecord objPara)
        {
            BEXRModel.UpdateExhibitionRecord_B(objPara);
        }
    }
}