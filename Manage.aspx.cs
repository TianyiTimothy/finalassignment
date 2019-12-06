using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSWebsite
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // search key
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = page_search.Text;
            }

            // clear result
            page_result.InnerHtml = "";
            // Table_Result


            // default query: select everything
            string query = "SELECT * FROM pages";

            if (searchkey != "")
            {
                query += " WHERE PAGEID LIKE '%" + searchkey + "%' ";
                query += "OR PAGETITLE LIKE '%" + searchkey + "%' ";
                query += "OR PAGEBODY LIKE '%" + searchkey + "%' ";
            }

            // order by isPublished, show those published one first
            query += " ORDER BY isPublished DESC;";

            // todo: when click table head, order by the clicked column


            // result set for result from mysql
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            // get result with db class function
            ResultSet = new WEBSITEDB().List_Query(query);

            foreach (Dictionary<String, String> row in ResultSet)
            {
                //page_result.InnerHtml += "<td>";

                string pageid = row["pageid"];
                string pagetitle = row["pagetitle"];
                string pagebody = row["pagebody"];
                string ispublished = row["isPublished"];

                //< div class="col-xs-3">PAGE ID</div>

                page_result.InnerHtml += "<div class=\"row\" style=\"margin-top: 10px; padding-top: 10px; border-top: solid #DDD 1px;\">";
                page_result.InnerHtml += "<div class=\"col-xs-3\">" + pageid + "</div>";
                page_result.InnerHtml += "<div class=\"col-xs-3\"> <a href=\"DetailPage.aspx?pageid=" + pageid + "\">" + pagetitle + "</a></div>";
                //page_result.InnerHtml += "<div class=\"col-xs-3\">" + pagebody + "</div>";
                page_result.InnerHtml += "<div class=\"col-xs-3\">" + ispublished + "</div>";
                page_result.InnerHtml += "<div class=\"col-xs-3\">" +
                    "<a class=\"btn btn-info\" href=\"EditPage.aspx?pageid=" + pageid + "\">Edit</a>" +
                    "</div>";
                page_result.InnerHtml += "</div>";

            }

        }
    }
}