using Npgsql;
using System.Data;

namespace RentCar_Csharp.DB
{
    public class RentcarContext
    {
        public void RentalDB()
        {
            string connectionString = "Server=172.17.0.2;port=5432;Database=RentalSystem;Username=postgres;Password=efrei";
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

                /*
                 * 
                 * 
                 * Using joins for querying and data processing
                 *
                 *
                 *
                 */

                conn.Close();
            }
        }
    }
}
