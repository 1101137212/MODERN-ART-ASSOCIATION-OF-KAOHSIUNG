﻿using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        #region Public Methods

        public void CreateArtisticworksdata_B(Artisticworks objPara)
        {
            BAWSModel.CreateArtisticworks_B(objPara);
        }

        #endregion Public Methods
    }
}