using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public partial class ArtisticworksController : Controller
    {

        public string Getdata()
        {
            return c.GetArtisticworks();


        }
    }
}