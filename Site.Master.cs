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
            List<HTMLPAGE> Pages = new WEBSITEDB().List_Query(query);

            foreach (HTMLPAGE page in Pages)
            {
                string pagetitle = page.PageTitle;
                string pageid = page.PageId;

                navigation.InnerHtml += "<li> <a href=\"DetailPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></li>";
            }

        }
    }
}