using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSWebsite
{
    public partial class EditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get pageid
            string pageid = Request.QueryString["pageid"];
            // if there is not pageid in url
            if (String.IsNullOrEmpty(pageid))
            {
                pageWrapper.InnerText = "<h1>ERROR: This page does not exist</h1>";
                return;
            }

            // show existed data
            // get pagetitle and pagebody and isPublished query 
            // if isPublished, remain delete button. If not, show recover button
            string query = "SELECT pagetitle, pagebody, isPublished FROM pages WHERE pageid = " + pageid;

            List<Dictionary<string, string>> ResultSet = new WEBSITEDB().List_Query(query);

            foreach (Dictionary<string, string> row in ResultSet)
            {
                string pagetitle = row["pagetitle"];
                string pagebody = row["pagebody"];
                string isPublished = row["isPublished"];

                // show current data
                PageTitle.Text = pagetitle;
                PageBody.Text = pagebody;

                // if isPublished, hide recover button. If not, hide recover button
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
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            string pagetitle = PageTitle.Text;
            string pagebody = PageBody.Text;

            // get pageid
            string pageid = Request.QueryString["pageid"];

            // execute update query
            //UPDATE pages SET pagetitle = "123", pagebody = "321", isPublished = true WHERE pageid = 1
            string query = "UPDATE pages SET pagetitle = \"" + pagetitle + "\"" +
                ", pagebody = \"" + pagebody + "\"" +
                " WHERE pageid = " + pageid;

            // db instance
            WEBSITEDB db = new WEBSITEDB();
            // execute crud query
            db.CRUD_Query(query);

            Response.Redirect("DetailPage.aspx?pageid=" + pageid);
        }
        // todo remix both delete and recover function
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