using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public bool CityActive { get; set; }

        public int RegionID { get; set; }
        public virtual Region Regions { get; set; }
    }
}