using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class Area
    {
        public int AreaID { get; set; }
        public int CityID { get; set; }
        public int PostalCodeID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }        
        public bool AreaActive { get; set; }
        public virtual Region Regions { get; set; }
        public virtual City Cities { get; set; }
        public virtual PostalCode PostalCodes { get; set; }
    }
}