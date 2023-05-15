using Microsoft.Data.SqlClient;
using System.Data;

string connectionString =
             "Server=tcp:volleyballservbp.database.windows.net,1433;Initial Catalog=VolleyballDB;Persist Security Info=False;User ID=bogdan;Password=Stocznia2014;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    using (SqlCommand command = new SqlCommand("InsertPerson", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@FirstName", "John");
        command.Parameters.AddWithValue("@LastName", "Doe");
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} rows affected.");
    }
    using (SqlCommand command = new SqlCommand("GetAllPersons", connection))
    {
        command.CommandType = CommandType.StoredProcedure;

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader.GetInt32(0)}," +
                    $" FirstName: { reader.GetString(1)}," +
                    $" LastName: { reader.GetString(2)} ");
            }
        }
    }
    using (SqlCommand command = new SqlCommand("UpdatePerson", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Id", 1);
        command.Parameters.AddWithValue("@FirstName", "UpdatedFirstName");
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} rows affected.");
    }
    using (SqlCommand command = new SqlCommand("DeletePerson", connection))
    {
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@Id", 1);
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffected} rows affected.");
    }
}