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
            string query = "SELECT pagetitle, pagebody, isPublished FROM pages WHERE pageid = " + pageid;

            List<Dictionary<string, string>> ResultSet = new WEBSITEDB().List_Query(query);

            Dictionary<string, string> row = ResultSet[0];
            string pagetitle = row["pagetitle"];
            string pagebody = row["pagebody"];
            string isPublished = row["isPublished"];

            // get the page id first
            PageTitle.InnerText = pagetitle;
            PageBody.InnerText = pagebody;

            // add edit button
            PageAction.InnerHtml =
                "<a class=\"btn btn-info\" href=\"EditPage.aspx?pageid=" + pageid + "\">Edit</a>";

            // add delete or recover button
            if (isPublished == "True" || isPublished == "1")
            {
                // if isPublished, hide recover button
                RecoverBtn.Style.Add("display", "none");
            }
            else
            {
                // if not, hide delete button
                DeleteBtn.Style.Add("display", "none");

            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            // get pageid
            string pageid = Request.QueryString["pageid"];

            bool isPublished = false;

            // execute update query
            //UPDATE pages SET pagetitle = "123", pagebody = "321", isPublished = true WHERE pageid = 1
            string query = "UPDATE pages SET isPublished = " + isPublished +
                " WHERE pageid = " + pageid;

            // db instance
            WEBSITEDB db = new WEBSITEDB();
            // execute crud query
            db.CRUD_Query(query);

            Response.Redirect("Manage.aspx");
        }

        protected void Recover_Click(object sender, EventArgs e)
        {
            // get pageid
            string pageid = Request.QueryString["pageid"];

            bool isPublished = true;

            // execute update query
            //UPDATE pages SET pagetitle = "123", pagebody = "321", isPublished = true WHERE pageid = 1
            string query = "UPDATE pages SET isPublished = " + isPublished +
                " WHERE pageid = " + pageid;

            // db instance
            WEBSITEDB db = new WEBSITEDB();
            // execute crud query
            db.CRUD_Query(query);

            Response.Redirect("DetailPage.aspx?pageid=" + pageid);
        }
    }
}