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
        public string GetResearchFielddata_B()
        {
            return RF.GetResearchField_B();
        }

        public void CreateResearchFielddata_B(ResearchField ResearchField)
        {
            RF.CreateResearchField_B(ResearchField);
        }

        public void DeleteResearchFielddata_B(int ResearchField_ID)
        {
            RF.DeleteResearchField_B(ResearchField_ID);
        }

        public void UpdateResearchFielddata_B(ResearchField ResearchField)
        {
            RF.UpdateResearchField_B(ResearchField);
        }
    }
}