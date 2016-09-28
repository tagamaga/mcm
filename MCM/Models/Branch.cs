using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class Branch
    {
        public int BranchID { get; set; }
        public int BankID { get; set; }
        public int AreaID { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchInfo { get; set; }
        public bool BranchActive { get; set; }

        public virtual Bank Banks { get; set; }
        public virtual Area Areas { get; set; }
    }
}