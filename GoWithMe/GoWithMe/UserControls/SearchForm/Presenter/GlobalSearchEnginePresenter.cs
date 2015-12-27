using GoWithMe.SearchForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoWithMe.SearchForm.View;

namespace GoWithMe.UserControls.SearchForm.Presenter
{
    public interface IGlobalSearchEnginePresenter
    {
        SearchFormItem GetSearchData();
        void SetPlaceToWidth();
        void SetPlaceFromWidth();
    }

    public class GlobalSearchEnginePresenter
    {
        protected ISearchFormView _view;

        public GlobalSearchEnginePresenter(ISearchFormView view)
        {
            this._view = view;
        }
    }
}