using MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models.DefinedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers.AWS
{
    public partial class AWSController : Controller
    {
        public string GetArtisticworksdata(GetArtisticworksByID obj)
        {
            IList<GetArtisticworksByID> objArtisticworksdata = AWS.GetArtisticworksByID(obj);
            return Base.ConvertToJson<GetArtisticworksByID>(objArtisticworksdata);
        }
    }
}