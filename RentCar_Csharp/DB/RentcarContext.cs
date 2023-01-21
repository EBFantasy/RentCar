using Npgsql;
using System.Data;

namespace RentCar_Csharp.DB
{
    public class RentcarContext
    {
        public void RentalDB()
        {
            // Please configure the server's IP address based on the results of the inquiry. You can go to the pgadmin page to confirm the connection.
            string connectionString = "Server=172.17.0.2;port=5432;Database=RentalSystem;Username=postgres;Password=rentalcar";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //Returns a value of true to verify that the database has been successfully connected.
                    Console.WriteLine("Connected to the database");
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                /*****************************Using joins for querying and data processing*****************************/

                using (var cmd = new NpgsqlCommand("CREATE TABLE users (userId INTEGER PRIMARY KEY, name VARCHAR(255), gender VARCHAR(255), phoneN INTEGER, account VARCHAR(255))", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new NpgsqlCommand("INSERT INTO users (userId, name, gender, phoneN, account) VALUES (@userId, @name, @gender, @phoneN, @account)", conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769);
                    cmd.Parameters.AddWithValue("name", "Noltz");
                    cmd.Parameters.AddWithValue("gender", "female");
                    cmd.Parameters.AddWithValue("phoneN", 0728523143);
                    cmd.Parameters.AddWithValue("account", "customer");
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
