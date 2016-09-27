using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCM.Models
{
    public class PostalCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostalCodeID { get; set; }
        public bool PostalCodeActive { get; set; }
    }
}