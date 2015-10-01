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
        public string GetMediaReportsdata_B()
        {
            return BMDRModel.GetMediaReports_B();
        }

        public void CreateMediaReportsdata_B(MediaReports MediaReports)
        {
            BMDRModel.CreateMediaReports_B(MediaReports);
        }

        public void DeleteMediaReportsdata_B(int MediaReports_ID)
        {
            BMDRModel.DeleteMediaReports_B(MediaReports_ID);
        }

        public void UpdateMediaReportsdata_B(MediaReports MediaReports)
        {
            BMDRModel.UpdateMediaReports_B(MediaReports);
        }
    }
}