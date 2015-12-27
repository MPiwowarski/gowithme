using GoWithMe.SearchForm.Data;
using GoWithMe.UserControls.SearchForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoWithMe.SearchForm.View;

namespace GoWithMe.SearchForm.Presenter.Home
{
    public interface ISearchFormPresenter: IGlobalSearchEnginePresenter
    {
        
    }

    public class SearchFormPresenter : GlobalSearchEnginePresenter, ISearchFormPresenter
    {

        public SearchFormPresenter(ISearchFormView view): base(view)
        {
                  
        }

        public void SetPlaceFromWidth()
        {
            _view.PlaceFromWidth = 230;
        }
        public void SetPlaceToWidth()
        {
            _view.PlaceToWidth = 230;
        }

        public SearchFormItem GetSearchData()
        {
            return _view.SearchData;
        }





    }
}