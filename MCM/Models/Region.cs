using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCM.Models
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public bool RegionActive { get; set; }  

    }
}