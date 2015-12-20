using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoWithMe.Model.ModelDB
{
    public class tblUser
    {
        public tblUser()
        {
            this.OfferingRides = new HashSet<tblOfferingRide>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [DefaultValue("false")]
        public bool IsLogg { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<tblOfferingRide> OfferingRides { get; set; }

        public tblImage Image { get; set; }
    }
}