using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class MemberLocation
    {
        public int MemberLocationID { get; set; }
        public int MemberID { get; set; }
        public int RegionID { get; set; }

        public virtual Member Members { get; set; }
        public virtual Region Regions { get; set; }
    }
}