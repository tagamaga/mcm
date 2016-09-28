using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class Suburb
    {
        public int SuburbID { get; set; }
        public int AreaID { get; set; }
        public string SuburbCode { get; set; }
        public string SuburbName { get; set; }
        public bool SuburbActive { get; set; }

        public virtual Area Areas { get; set; }
    }
}