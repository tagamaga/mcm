using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCM.Models
{
    public class Area
    {
        public int AreaID { get; set; }
        public int RegionID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public int PostalCodeID { get; set; }
        public bool AreaActive { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<PostalCode> PostalCodes { get; set; }
    }
}