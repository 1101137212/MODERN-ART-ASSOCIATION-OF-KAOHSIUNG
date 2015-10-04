using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Controllers
{
    public class BaseController
    {
        public string ConvertToJson<T>(IList<T> dataList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(dataList);
        }
    }
}