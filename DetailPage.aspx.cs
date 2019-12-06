using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSWebsite
{
    public partial class DetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if goes here directly, something goes wrong.
            string pageid = Request.QueryString["pageid"];

            if (String.IsNullOrEmpty(pageid))
            {
                PageTitle.InnerText = "ERROR";
                PageBody.InnerText = "This page does not exist";
                return;
            }

            // query with pageid
            string query = "SELECT pagetitle, pagebody FROM pages WHERE pageid = " + pageid;

            List<Dictionary<string, string>> ResultSet = new WEBSITEDB().List_Query(query);

            foreach (Dictionary<string, string> row in ResultSet)
            {
                string pagetitle = row["pagetitle"];
                string pagebody = row["pagebody"];

                // get the page id first
                PageTitle.InnerText = pagetitle;
                PageBody.InnerText = pagebody;

                PageAction.InnerHtml =
                    "<a href=\"EditPage.aspx?pageid=" + pageid + "\">Edit</a>";
            }
        }
    }
}