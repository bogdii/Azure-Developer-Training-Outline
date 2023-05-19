using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01NewASPWebApp
{
    public partial class VolleyballPlayers : System.Web.UI.Page
    {
        public string SampleString { get; set; }

        public List<Player> PlayerList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PlayerList = new List<Player>();
            string sampleString = "hello";
            // Response.Write(sampleString);
            SampleString = sampleString;

            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=VolleyballDatabase;Integrated Security=True;";

            List<Player> list = new List<Player>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command =
                    new SqlCommand("SELECT Id, First_Name, Last_Name, country FROM Players", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PlayerList.Add(new Player()
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Country = reader.GetString(3),
                            });
                            /*Response.Write($"" +
                                $"Id: {reader.GetInt32(0)}, " +
                                $"FirstName: {reader.GetString(1)}, " +
                                $"LastName: {reader.GetString(2)}");
                            Response.Write("<br>");*/
                        }
                    }
                }



            }




        }
    }
}