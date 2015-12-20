using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoWithMe.Model.ModelDB
{
    public class tblOfferingRide
    {      
        [Key]
        public int ID { get; set; }
        [Required]
        public string FromPlace { get; set; }
        [Required]
        public string ToPlace { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string CarModel { get; set; }     
        [Required]
        public DateTime OffertDate { get; set; }
        [Required]
        public DateTime RideDate { get; set; }      
        [Required]
        public string OffertDescription { get; set; }
        [Required]
        public int NumberOfSits { get; set;}

        //Foreign key to tblUser
        public int tblUserId { get; set; }
     
        public virtual tblUser Users { get; set; }
    }
}