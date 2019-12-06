using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSWebsite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // set up navigation
            //navigation.InnerHtml = "<li><a href=\"Manage\">Manage</a></li>";
            // clean navigation
            navigation.InnerHtml = "";

            // query for page titles
            string query = "SELECT pageid, pagetitle FROM pages WHERE isPublished = true";
            // get page titles from db
            List<Dictionary<string, string>> ResultSet = new WEBSITEDB().List_Query(query);

            foreach (Dictionary<String, String> row in ResultSet)
            {
                string pagetitle = row["pagetitle"];
                string pageid = row["pageid"];

                navigation.InnerHtml += "<li> <a href=\"DetailPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></li>";
            }

        }
    }
}