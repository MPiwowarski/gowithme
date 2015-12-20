using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace GoWithMe.Model.Extras
{
    public interface IExtrasModel
    {
        string CreatePassword(int length);
        DateTime AddDepartureHourToRideDate(string hours, string minutes, DateTime RideDate);
    }

    public class ExtrasModel:IExtrasModel
    {
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public DateTime AddDepartureHourToRideDate(string hours, string minutes, DateTime RideDate)
        {
            string userInput = hours + ":" + minutes + ":00";
            var time = TimeSpan.Parse(userInput);
            return RideDate.Add(time);

        }
    }
}