using GoWithMe.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace GoWithMe
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ////this command recreate table if doesnt exist
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GoWithMeDBContext>());

            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
            new ScriptResourceDefinition
            {
                Path = "~/jQueryFiles/jquery-1.6.4.min.js",
                DebugPath = "~/jQueryFiles/jquery-1.6.4.min.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.4.1.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.4.1.js"
            });
        }
    }
}