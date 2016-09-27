using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class MemberLocation
    {
        public int mLocationID { get; set; }
        public int MemberID { get; set; }
        public int RegionID { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}