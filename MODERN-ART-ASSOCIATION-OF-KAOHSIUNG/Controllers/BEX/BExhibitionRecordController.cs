﻿using System;
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
        public string GetExhibitionRecorddata_B()
        {
            return EXR.GetExhibitionRecord_B();
        }

        public void CreateExhibitionRecorddata_B(ExhibitionRecord ExhibitionRecord)
        {
            EXR.CreateExhibitionRecord_B(ExhibitionRecord);
        }

        public void DeleteExhibitionRecorddata_B(int ExhibitionRecord_ID)
        {
            EXR.DeleteExhibitionRecord_B(ExhibitionRecord_ID);
        }

        public void UpdateExhibitionRecorddata_B(ExhibitionRecord ExhibitionRecord)
        {
            EXR.UpdateExhibitionRecord_B(ExhibitionRecord);
        }
    }
}