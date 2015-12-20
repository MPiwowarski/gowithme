using GoWithMe.SearchForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoWithMe.SearchForm.Presenter
{
    public class SearchFormPresenter : ISearchFormPresenter
    {

        private View.ISearchFormView _view;


        public SearchFormPresenter(View.ISearchFormView view)
        {
            this._view = view;
        }

        public int SetPlaceFromWidth
        {
            set
            {
                _view.PlaceFromWidth = value;
            }
        }
        public int SetPlaceToWidth
        {
            set
            {
                _view.PlaceToWidth = value;
            }
        }

        public SearchFormItem GetSearchData
        {
            get
            {
                return _view.SearchData;
            }
        }

        



    }
}