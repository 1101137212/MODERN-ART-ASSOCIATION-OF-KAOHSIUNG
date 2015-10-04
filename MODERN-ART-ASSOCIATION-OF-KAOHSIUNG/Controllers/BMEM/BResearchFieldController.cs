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
        public IList<ResearchField> GetResearchFielddata_B()
        {
            return BRFModel.GetResearchField_B();
        }

        public void CreateResearchFielddata_B(ResearchField objPara)
        {
            BRFModel.CreateResearchField_B(objPara);
        }

        public void DeleteResearchFielddata_B(ResearchField objPara)
        {
            BRFModel.DeleteResearchField_B(objPara);
        }

        public void UpdateResearchFielddata_B(ResearchField objPara)
        {
            BRFModel.UpdateResearchField_B(objPara);
        }
    }
}