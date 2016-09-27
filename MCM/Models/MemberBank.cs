using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class MemberBank
    {
        public int MemberBankID { get; set; }
        public int MemberID { get; set; }
        public int BranchID { get; set; }

        public virtual Member Members { get; set; }
        public virtual Branch Branches { get; set; }
    }
}