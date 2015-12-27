using GoWithMe.Model.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoWithMe.Model.ModelDB;

namespace GoWithMe.Model.Repo
{
    public interface IDataRepository
    {
        //TODO Zrobic zapytanie do pobierania danych o wszystkich przejazdach z wyszukiwarki
        List<searchEngineResult> GetSearchEngineResult(string fromPlace, string toPlace, DateTime? rideDate);
    }

    public class DataRepository : IDataRepository
    {

        public static GoWithMeDBContext DBContext = new GoWithMeDBContext();

        //public List<searchEngineResult> GetSearchEngineResult(string fromPlace, string toPlace, DateTime? rideDate)
        //{

        //    List<searchEngineResult> result = DBContext.Users
        //       .Join(DBContext.OfferingRide,
        //       u => u.ID,
        //       o => o.tblUserId,
        //       (u, o) => new { u, o }).

        //       Where(s => s.o.FromPlace == fromPlace && s.o.ToPlace == toPlace).
        //       Select(s => new searchEngineResult
        //       {
        //           UserId = s.u.ID,
        //           UserName = s.u.Name,
        //           UserSurname = s.u.Surname,
        //           RideDate = s.o.RideDate,
        //           FromPlace = s.o.FromPlace,
        //           ToPlace = s.o.ToPlace,
        //           CarModel = s.o.CarModel,
        //           Price = s.o.Price,
        //           NumberOfSits = s.o.NumberOfSits,
        //           PhoneNumber = s.u.PhoneNumber,
        //           Description=s.o.OffertDescription

        //       }).ToList()
        //       .Join(DBContext.Images,
        //       ser => ser.UserId,
        //       i => i.UserId,
        //       (ser, i) => new { ser, i }).
        //       Where(s => DBContext.Images.Select(x=>x.UserId).Contains(s.i.UserId)).
        //       Select(s => new searchEngineResult
        //       {
        //           UserId = s.ser.UserId,
        //           UserName = s.ser.UserName,
        //           UserSurname = s.ser.UserSurname,
        //           RideDate = s.ser.RideDate,
        //           FromPlace = s.ser.FromPlace,
        //           ToPlace = s.ser.ToPlace,
        //           CarModel = s.ser.CarModel,
        //           Price = s.ser.Price,
        //           NumberOfSits = s.ser.NumberOfSits,         
        //           PhoneNumber=s.ser.PhoneNumber,
        //           Description=s.ser.Description,
        //           Image = s.i.Image
        //       }).ToList();

        //    int iterator = 0;
        //    foreach(var x in result)
        //    {
        //        x.Lp += iterator;
        //    }

        //    return result;

        //}

        public List<searchEngineResult> GetSearchEngineResult(string fromPlace, string toPlace, DateTime? rideDate)
        {

            List<searchEngineResult> result = DBContext.Users
               .Join(DBContext.OfferingRide,
               u => u.ID,
               o => o.tblUserId,
               (u, o) => new { u, o }).

               Where(s => s.o.FromPlace == fromPlace && s.o.ToPlace == toPlace).
               Select(s => new searchEngineResult
               {
                   UserId = s.u.ID,
                   UserName = s.u.Name,
                   UserSurname = s.u.Surname,
                   RideDate = s.o.RideDate,
                   FromPlace = s.o.FromPlace,
                   ToPlace = s.o.ToPlace,
                   CarModel = s.o.CarModel,
                   Price = s.o.Price,
                   NumberOfSits = s.o.NumberOfSits,
                   PhoneNumber = s.u.PhoneNumber,
                   Description = s.o.OffertDescription

               }).ToList();

            if (result.Any())
            {
                List<int> ids = result.Select(y => y.UserId).ToList();
                var images = DBContext.Images.Where(x => ids.Contains(x.UserId)).ToList();

                foreach(var item in result)
                {
                    item.Image = images.Where(x => (images.Select(y => y.UserId)).Contains(item.UserId)).Select(x => x.Image).FirstOrDefault();
                }

                int iterator = 0;
                foreach (var x in result)
                {
                    x.Lp += iterator;
                }
            }
            return result;

        }
    }

    [Serializable]
    public class searchEngineResult
    {
        public int? Lp { get; set; }
        public int UserId { get; set; }
        public byte[] Image { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime RideDate { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public string CarModel { get; set; }
        public int Price { get; set; }
        public int NumberOfSits { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}