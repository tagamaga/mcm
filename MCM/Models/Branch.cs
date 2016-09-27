using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
    }
}