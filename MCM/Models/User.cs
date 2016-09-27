using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCM.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string Password { get; set; }
        public bool UserActive { get; set; }

        public virtual ICollection<UserType> UserTypes { get; set; }

    }
}