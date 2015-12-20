using GoWithMe.SearchForm.Presenter;
using GoWithMe.SearchForm.View;
using GoWithMe.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class Home : System.Web.UI.Page
    {
        private SearchFormPresenter _searchFormPresenter;
        private  ISearchFormView _searchFormView;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _searchFormView = (ISearchFormView)SearchForm_SearchEngine;
            _searchFormPresenter = new SearchFormPresenter(_searchFormView);
            
            _searchFormPresenter.SetPlaceFromWidth = 230;
            _searchFormPresenter.SetPlaceToWidth = 230;
            //
        }

        
    }
}