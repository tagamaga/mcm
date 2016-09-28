using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int UserID { get; set; }
        public string Cellphone { get; set; }
        public string Cellphone2 { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set;  }
        public bool MemberActive { get; set; }

        public virtual User Users { get; set; }
    }
}