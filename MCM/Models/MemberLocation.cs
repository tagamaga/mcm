using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCM.Models
{
    public class MemberLocation
    {
        public int mLocationID { get; set; }
        public int MemberID { get; set; }
        public int? AreaID { get; set; }
        public int RegionID { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}