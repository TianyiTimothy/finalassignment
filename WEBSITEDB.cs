using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CMSWebsite
{
    public class WEBSITEDB
    {

        // this is me running out of time
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string database = "WEBSITE";
        readonly string port = "3306";
        readonly string password = "root";

        public List<HTMLPAGE> List_Query(string query)
        {
            List<HTMLPAGE> Pages = new List<HTMLPAGE>();

            List<Dictionary<string, string>> ResultSet = new List<Dictionary<string, string>>();
            MySqlConnection Connect = connectDatabase();

            try
            {
                // connect to db
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                // get result set ( class is mysqldatareader )
                MySqlDataReader resultset = cmd.ExecuteReader();

                // move result set from mysqldatareader to list<dictionary>
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                    }
                    ResultSet.Add(Row);
                }
                // no need to use resultset anymore
                resultset.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("exception when connecting to db: ");
                Debug.WriteLine(ex.ToString());
            }
            // close connection
            Connect.Close();

            foreach (Dictionary<string, string> row in ResultSet)
            {
                string pagetitle = row["pagetitle"];
                string pagebody = row["pagebody"];
                string isPublished = row["isPublished"];

                // new instance of page
                HTMLPAGE page = new HTMLPAGE
                {
                    PageTitle = pagetitle,
                    PageBody = pagebody,
                    IsPublished = isPublished
                };

                // add data to list page
                Pages.Add(page);


            }

            return Pages;
        }

        private MySqlConnection connectDatabase()
        {
            // connect to database
            MySqlConnection Connect = new MySqlConnection("server=" + server + "; " +
                "user=" + user + "; " +
                "database=" + database + "; " +
                "port=" + port + "; " +
                "password=" + password + "; ");

            return Connect;
        }

        public void CRUD_Query(string query)
        {
            //INSERT INTO `pages`(`pageid`, `pagetitle`, `pagebody`, `isPublished`) VALUES(null, "Dairy 12-4", "Just finished all the exams !! Happy Holiday !!", 1)
            // connect to database
            MySqlConnection Connect = connectDatabase();

            try
            {
                // connect to db
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                // execute the query
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("exception when connecting to db (CRUD): ");
                Debug.WriteLine(ex.ToString());
            }
            // close connection
            Connect.Close();

        }
    }
}