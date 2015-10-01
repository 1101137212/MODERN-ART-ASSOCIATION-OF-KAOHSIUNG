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
        public string GetResearchFieldRecorddata_B()
        {
            return BRFRModel.GetResearchFieldRecord_B();
        }

        public void CreateResearchFieldRecorddata_B(ResearchFieldRecord ResearchFieldRecord)
        {
            BRFRModel.CreateResearchFieldRecord_B(ResearchFieldRecord);
        }

        public void DeleteResearchFieldRecorddata_B(int ResearchFieldRecord_ID)
        {
            BRFRModel.DeleteResearchFieldRecord_B(ResearchFieldRecord_ID);
        }

        public void UpdateResearchFieldRecorddata_B(ResearchFieldRecord ResearchFieldRecord)
        {
            BRFRModel.UpdateResearchFieldRecord_B(ResearchFieldRecord);
        }
    }
}