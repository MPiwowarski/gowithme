using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoWithMe.Model.Repo
{
    public interface IDataRepository
    {
        //TODO Zrobic zapytanie do pobierania danych o wszystkich przejazdach z wyszukiwarki
        List<searchEngineResult> GetSearchEngineResult(string fromPlace,string toPlace,DateTime? rideDate);
    }

    public class DataRepository: IDataRepository
    {
        
        public static GoWithMeDBContext DBContext = new GoWithMeDBContext();

        public List<searchEngineResult> GetSearchEngineResult(string fromPlace, string toPlace, DateTime? rideDate)
        {
            //searchEngineResult result = DBContext.OfferingRide.Where(x => x.FromPlace == fromPlace && x.ToPlace == toPlace && x.RideDate == rideDate).
            //    Join(DBContext.Users,
            //    d => d.tblUserId,
            //    e => e.ID,
            //    (d, e) =>new { d, e});

            //List<searchEngineResult> result = DBContext.Users
            //    .Join(DBContext.OfferingRide,
            //    u => u.ID,
            //    o => o.tblUserId,
            //    (u, o) => new { u, o }).                          
            //    Where(s => s.o.FromPlace == fromPlace && s.o.ToPlace == toPlace).
            //    Select(s => new searchEngineResult
            //    {
            //        UserId= s.u.ID,
            //        UserName=s.u.Name,
            //        UserSurname=s.u.Surname,
            //        RideDate= s.o.RideDate,
            //        FromPlace= s.o.FromPlace,
            //        ToPlace= s.o.ToPlace,
            //        CarModel=s.o.CarModel,
            //        Price=s.o.Price,
            //        NumberOfSits=s.o.NumberOfSits

            //    }).ToList();


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
                   NumberOfSits = s.o.NumberOfSits

               }).ToList()
               .Join(DBContext.Images,
               ser => ser.UserId,
               i => i.UserId,
               (ser, i) => new { ser, i }).
               Where(s => s.ser.UserId == s.i.UserId).
               Select(s => new searchEngineResult
               {
                   UserId = s.ser.UserId,
                   UserName = s.ser.UserName,
                   UserSurname = s.ser.UserSurname,
                   RideDate = s.ser.RideDate,
                   FromPlace = s.ser.FromPlace,
                   ToPlace = s.ser.ToPlace,
                   CarModel = s.ser.CarModel,
                   Price = s.ser.Price,
                   NumberOfSits = s.ser.NumberOfSits,
                   Image = s.i.Image
               }).ToList();

            int iterator = 0;
            foreach(var x in result)
            {
                x.Lp += iterator;
            }

            return result;

        }
    }

    [Serializable]
    public class searchEngineResult
    {
        public int? Lp{ get;set;}
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
    }
}