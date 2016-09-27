using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class MemberBank
    {
        public int MemberBankID { get; set; }
        public int MemberID { get; set; }
        public int BankID { get; set; }
        public int BranchID { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}