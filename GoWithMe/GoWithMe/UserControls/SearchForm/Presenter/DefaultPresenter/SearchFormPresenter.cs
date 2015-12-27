using GoWithMe.SearchForm.Data;
using GoWithMe.SearchForm.View;
using GoWithMe.UserControls.SearchForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoWithMe.SearchForm.Presenter.DefaultPresenter
{
    public interface ISearchFormPresenter: IGlobalSearchEnginePresenter
    {
        
    }

    public class SearchFormPresenter : GlobalSearchEnginePresenter, ISearchFormPresenter
    {

        public SearchFormPresenter(ISearchFormView view) : base(view)
        {

        }

        public void SetPlaceFromWidth()
        {
            _view.PlaceFromWidth = 200;
        }
        public void SetPlaceToWidth()
        {
            _view.PlaceToWidth = 200;
        }

        public SearchFormItem GetSearchData()
        {
            return _view.SearchData;
        }





    }
}