using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GoWithMe.Model.ModelDB
{
    public class tblImage
    {
        [Key, ForeignKey("User")]
        public int ID { get; set; }
        
        [Required]
        public byte[] Image { get; set; }

        
        public int UserId { get; set; }

        public tblUser User { get; set; }
    }
}