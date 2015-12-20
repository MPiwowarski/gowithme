using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoWithMe.SearchForm.Data
{
    [Serializable]
    public class SearchFormItem : ISearchFormItem
    {
        public DateTime? DateRide
        {
            get;
            set;         
        }

        public string PlaceFrom
        {
            get;
            set;
        }

        public string PlaceTo
        {
            get;
            set;
        }
    }
}