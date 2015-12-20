using GoWithMe.SearchForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithMe.SearchForm.Presenter
{
    public interface ISearchFormPresenter
    {
        SearchFormItem GetSearchData { get; }
        int SetPlaceToWidth { set; }
        int SetPlaceFromWidth { set; }
    }
}
