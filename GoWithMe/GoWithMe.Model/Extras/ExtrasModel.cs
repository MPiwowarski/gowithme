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
        /// <summary>
        /// convertin polish letters: ą,ć,ę,ń,ó,ł,ż to english letters a,c,e,n,o,l,z
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public string ConvertGivenPhrase(string phrase)
        {
            phrase = phrase.ToLower();
            phrase = phrase.Replace('ą', 'a');
            phrase = phrase.Replace('ć', 'c');
            phrase = phrase.Replace('ę', 'e');
            phrase = phrase.Replace('ń', 'n');
            phrase = phrase.Replace('ó', 'o');
            phrase = phrase.Replace('ł', 'l');
            phrase = phrase.Replace('ż', 'z');

            return phrase;            
        }
    }
}