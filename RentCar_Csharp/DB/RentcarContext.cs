using Npgsql;

namespace RentCar_Csharp.DB
{
    public class RentcarContext
    {
        public void RentalDB()
        {
            // Please configure the server's IP address based on the results of the inquiry. You can go to the pgadmin page to confirm the connection.
            // 
            string connectionString = "Server=127.0.0.1;port=5432;Database=postgres;Username=postgres;Password=efrei";
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

                using (var cmd = new NpgsqlCommand("CREATE TABLE users (userId BIGINT PRIMARY KEY, name VARCHAR(255), gender VARCHAR(255), phoneN INTEGER, account VARCHAR(255))", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                /*
                // ALTER TABLE to make changes, here is an example for changing userID INTEGRES to GIFINT
                using (var cmd = new NpgsqlCommand("ALTER TABLE users ALTER COLUMN userId TYPE BIGINT;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                */

                using (var cmd = new NpgsqlCommand("INSERT INTO users (userId, name, gender, phoneN, account) VALUES (@userId, @name, @gender, @phoneN, @account)", conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769L);
                    cmd.Parameters.AddWithValue("name", "Noltz");
                    cmd.Parameters.AddWithValue("gender", "female");
                    cmd.Parameters.AddWithValue("phoneN", 0728523143);
                    cmd.Parameters.AddWithValue("account", "customer");
                    cmd.ExecuteNonQuery();
                }

                /*
                // update example
                using (var cmd = new NpgsqlCommand("UPDATE users SET name = @name WHERE userId = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769L);
                    cmd.Parameters.AddWithValue("name", "John Doe");
                    cmd.ExecuteNonQuery();
                }
                */

                /*
                // delete example
                using (var cmd = new NpgsqlCommand("DELETE FROM users WHERE userId = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769L);
                    cmd.ExecuteNonQuery();
                }
                */

                /*
                // query example
                using (var cmd = new NpgsqlCommand("SELECT * FROM users WHERE name = 'Noltz'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("userId: " + reader["userId"] + ", name: " + reader["name"] + ", gender: " + reader["gender"] + ", phoneN: " + reader["phoneN"] + ", account: " + reader["account"]);
                        }
                    }
                }
                */

                conn.Close();
            }
        }
    }
}
