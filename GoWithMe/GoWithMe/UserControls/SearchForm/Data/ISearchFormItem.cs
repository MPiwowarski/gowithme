using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithMe.SearchForm.Data
{
    public interface ISearchFormItem
    {
        string PlaceFrom { get; }
        string PlaceTo { get; }
        DateTime? DateRide { get; }
    }
}
