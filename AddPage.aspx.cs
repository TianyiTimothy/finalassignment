using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSWebsite
{
    public partial class AddPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // get user inputs
            string pagetitle = PageTitleInput.Text;
            string pagebody = PageBodyInput.Text;

            // todo: cant include single quote in pagebody.

            AddBtn.Click += Add_Click(pagetitle, pagebody);
        }

        private EventHandler Add_Click(string pagetitle, string pagebody)
        {
            // insert query, page - auto increment, isPublished - default true (1 in tinyint)
            string query = "INSERT INTO `pages`(`pageid`, `pagetitle`, `pagebody`) VALUES (" +
                null +
                "," + pagetitle +
                "," + pagebody + ")";

            // excute the insert query
            new WEBSITEDB().CRUD_Query(query);
            // jumb to manage page
            Response.Redirect("Manage.aspx");

            throw new NotImplementedException();
        }
    }
}