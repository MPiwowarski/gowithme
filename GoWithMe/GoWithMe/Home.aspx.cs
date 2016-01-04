using GoWithMe.SearchForm.Presenter.Home;
using GoWithMe.SearchForm.View;
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
        private ISearchFormView _searchFormView;
        protected void Page_Load(object sender, EventArgs e)
        {
            _searchFormView = (ISearchFormView)SearchForm_SearchEngine;
            _searchFormPresenter = new SearchFormPresenter(_searchFormView);
            
        }

        protected void offerRide_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}