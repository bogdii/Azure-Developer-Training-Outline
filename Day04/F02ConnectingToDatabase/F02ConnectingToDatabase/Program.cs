
using Microsoft.Data.SqlClient;

SqlConnection connection;

SqlCommand command;

SqlDataReader reader;

string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=VolleyballDataBase;Integrated Security=True;Pooling=False";
connection = new SqlConnection(connectionString);

command = new SqlCommand("select * from players", connection);

connection.Open();

reader = command.ExecuteReader();

while (reader.Read())
{
    string result = reader.GetValue(2) + " " + reader.GetValue(2);
    Console.WriteLine(result);
}

connection.Close(); 