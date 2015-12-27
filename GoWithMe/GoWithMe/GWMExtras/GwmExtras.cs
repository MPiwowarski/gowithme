using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoWithMe.GWMExtras
{
    public class GwmExtras
    {
        public static string ChangeNumberFormat(string number)
        {
            number = number.Insert(3, "-");
            number = number.Insert(7, "-");
            return number;
        }
    }
}