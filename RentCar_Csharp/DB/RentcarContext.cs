using Microsoft.EntityFrameworkCore;
using Npgsql;
using RentCar_Csharp.Models;

namespace RentCar_Csharp.DB
{
    public class RentcarContext : DbContext
    {
        public RentcarContext() { }
        public RentcarContext(DbContextOptions<RentcarContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;

        public string GetPassword()
        {
            if (!File.Exists("password.txt"))
            {
                Console.WriteLine("Enter password (it will be saved in password.txt)");
                string? s;
                do
                    s = Console.ReadLine();
                while (s == null || s.Length == 0);
                File.WriteAllText("password.txt", s);
            }
            string password = File.ReadAllText("password.txt");
            return password;
        }

        public void RentalDB()
        {
            // Please configure the server's IP address based on the results of the inquiry. You can go to the pgadmin page to confirm the connection.
            //
            string connectionString = TextConstants.DB_CONNECTIONPATH + GetPassword();
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


                using (var cmd = new NpgsqlCommand(TextConstants.DROP_ALL_USERS, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new NpgsqlCommand(TextConstants.CREATE_TABLE_USERS, conn))
                {
                    cmd.ExecuteNonQuery();
                }


                /*
                // ALTER TABLE to change the data type
                using (var cmd = new NpgsqlCommand("ALTER TABLE users ALTER COLUMN phoneN TYPE VARCHAR(255);", conn))
                {
                    cmd.ExecuteNonQuery();
                }*/



                using (var cmd = new NpgsqlCommand(TextConstants.INSERT_INTO_USERS, conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769L);
                    cmd.Parameters.AddWithValue("name", "Noltz");
                    cmd.Parameters.AddWithValue("gender", "female");
                    cmd.Parameters.AddWithValue("phoneN", 0728523143);
                    cmd.Parameters.AddWithValue("account", "customer");
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("userId", 126489984651312L);
                    cmd.Parameters.AddWithValue("name", "Christopher");
                    cmd.Parameters.AddWithValue("gender", "male");
                    cmd.Parameters.AddWithValue("phoneN", 0795713648);
                    cmd.Parameters.AddWithValue("account", "admin");
                    cmd.ExecuteNonQuery();
                }


                /*
                // update example
                using (var cmd = new NpgsqlCommand("UPDATE users SET phoneN = @phoneN WHERE userId = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("userId", 198671568324769L);
                    cmd.Parameters.AddWithValue("phoneN", "0728523143");
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("userId", 126489984651312L);
                    cmd.Parameters.AddWithValue("phoneN", "0795713648");
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


                // query example
                using (var cmd = new NpgsqlCommand("SELECT * FROM users WHERE name = 'Christopher'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("userId: " + reader["userId"] + ", name: " + reader["name"] + ", gender: " + reader["gender"] + ", phoneN: " + reader["phoneN"] + ", account: " + reader["account"]);
                        }
                    }
                }


                conn.Close();
            }
        }
    }
}
