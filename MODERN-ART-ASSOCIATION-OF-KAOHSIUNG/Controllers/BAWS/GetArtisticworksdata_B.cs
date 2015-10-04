using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.TableModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class BAWSController : Controller
    {
        #region Public Methods

        public string GetArtisticworksdata_B()
        {
            IList<Artisticworks> objData = BAWSModel.GetArtisticworks_B();
            return Base.ConvertToJson<Artisticworks>(objData);
        }

        #endregion Public Methods
    }
}