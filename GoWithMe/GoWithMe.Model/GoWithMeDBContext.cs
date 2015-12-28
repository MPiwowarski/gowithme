using GoWithMe.Model.ModelDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace GoWithMe.Model
{
    public class GoWithMeDBContext: DbContext
    {
        public virtual DbSet<tblUser> Users { get; set; }
        public virtual DbSet<tblOfferingRide> OfferingRide { get; set; }
        public virtual DbSet<tblImage> Images { get; set; }

      
    }
}