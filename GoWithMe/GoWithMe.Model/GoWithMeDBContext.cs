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
        public DbSet<tblUser> Users { get; set; }
        public DbSet<tblOfferingRide> OfferingRide { get; set; }
        public DbSet<tblImage> Images { get; set; }

      
    }
}