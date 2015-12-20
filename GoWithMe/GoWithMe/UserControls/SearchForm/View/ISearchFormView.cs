using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoWithMe.SearchForm.Data;
namespace GoWithMe.SearchForm.View
{
    public interface ISearchFormView
    {
        event EventHandler LoadSearchEngine;
        /// <summary>
        /// Input data in fields of SearchEngine stored in VS
        /// </summary>
        SearchFormItem SearchData{ get; set; }

        string PlaceFrom { get; set; }
        string PlaceTo { get; set; }

        /// <summary>
        /// Get set values in DateRideControl 
        /// </summary>
        string DateRideCtrl { get; set; }
        DateTime? DateRide { get; }

        string SearchStatusControlText { get; set; }

        void ClearForm();
    
        bool SearchEngineFormValidate();

        int PlaceFromWidth { get; set; }
        int PlaceToWidth { get; set; }

        

    }
}
