using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCM.Models
{
    public class Pledge
    {
        public int PledgeID{ get; set; }
        public int MemberID { get; set; }
        public DateTime PledgeDateTime{ get; set; }
        public decimal PledgeAmount { get; set; }
        public DateTime PledgeDueDateTime { get; set; }
        public int PeriodID { get; set; }
        public decimal InterestAmount { get; set; }
        public int Interest { get; set; }
        public bool PledgeActive { get; set; }
    }
}