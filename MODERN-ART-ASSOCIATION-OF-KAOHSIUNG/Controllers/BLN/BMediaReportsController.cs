using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.Backstage;
using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.BLN
{
    public partial class BLNController : Controller
    {
        public IList<MediaReports> GetMediaReportsdata_B()
        {
            return BMDRModel.GetMediaReports_B();
        }

        public void CreateMediaReportsdata_B(MediaReports objPara)
        {
            BMDRModel.CreateMediaReports_B(objPara);
        }

        public void DeleteMediaReportsdata_B(MediaReports objPara)
        {
            BMDRModel.DeleteMediaReports_B(objPara);
        }

        public void UpdateMediaReportsdata_B(MediaReports objPara)
        {
            BMDRModel.UpdateMediaReports_B(objPara);
        }
    }
}