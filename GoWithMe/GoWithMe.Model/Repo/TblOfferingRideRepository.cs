using GoWithMe.Model.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GoWithMe.Model.Repo
{
    public interface ITblOfferingRideRepository
    {
        void AddNewRideOffert(tblOfferingRide rideOffert);
    }

    public class TblOfferingRideRepository : DataRepository, ITblOfferingRideRepository
    {
        public void AddNewRideOffert(tblOfferingRide rideOffert)
        {
            DBContext.OfferingRide.Add(rideOffert);
            DBContext.SaveChanges();
        }
    }
}