using System;
using System.Collections.Generic;

namespace MCM.Models
{
    public class UserType
    {
        public int UserTypeID { get; set; }
        public string UserTypeCode { get; set; }
        public string UserTypeName { get; set; }
        public string UserTypeInfo { get; set; }
        public bool UserTypeActive { get; set; }
    }
}