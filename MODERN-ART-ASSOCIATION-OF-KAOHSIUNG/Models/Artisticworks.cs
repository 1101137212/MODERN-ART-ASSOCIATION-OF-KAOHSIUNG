using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG.Models
{
    public class Artisticworks
    {
        public int Artisticworks_ID { get; set; }
        public string Artisticworks_Name { get; set; }
        public DateTime? Artisticworks_Date { get; set; }
        public string Artisticworks_Picture { get; set; }
        public int Member_ID { get; set; }
    }
}