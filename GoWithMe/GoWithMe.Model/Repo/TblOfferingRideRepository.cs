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
        void DeleteSelectedItems(List<int> ids);
    }

    public class TblOfferingRideRepository : DataRepository, ITblOfferingRideRepository
    {
        private GoWithMeDBContext _context;

        public TblOfferingRideRepository()
        {
            this._context = DBContext;
        }

        public TblOfferingRideRepository(GoWithMeDBContext context)
        {
            this._context = context;
        }


        public void AddNewRideOffert(tblOfferingRide rideOffert)
        {
            _context.OfferingRide.Add(rideOffert);
            _context.SaveChanges();
        }
        public void DeleteSelectedItems(List<int> ids)
        {
            List<tblOfferingRide> itemsToDelete = new List<tblOfferingRide>();
            itemsToDelete = _context.OfferingRide.Where(x => ids.Contains(x.ID)).ToList();

            _context.OfferingRide.RemoveRange(itemsToDelete);
            _context.SaveChanges();
        }
    }
}