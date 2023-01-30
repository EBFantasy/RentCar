using Npgsql;
using System;

namespace RentCar_Csharp.DB
{
    public static class TextConstants
    {
        public static string DB_CONNECTIONPATH = "Server=127.0.0.1;port=5432;Database=postgres;Username=postgres;Password=";

        public static string DROP_ALL_USERS = "DROP TABLE IF EXISTS users";
        public static string DROP_ALL_CARS = "DROP TABLE IF EXISTS cars";
        public static string DROP_ALL_RESERVATIONS = "DROP TABLE IF EXISTS reservations";

        public static string QUERY_SELECT_ALL_USERS = "Select * from users";
        public static string QUERY_SELECT_ALL_CARS = "Select * from cars";
        public static string QUERY_SELECT_ALL_RESERVATIONS = "Select * from reservations";

        public static string CREATE_TABLE_USERS = "CREATE TABLE users (userId BIGINT PRIMARY KEY, name VARCHAR(255), gender VARCHAR(255), phoneN INTEGER, account VARCHAR(255))";
        public static string INSERT_INTO_USERS = "INSERT INTO users (userId, name, gender, phoneN, account) VALUES (@userId, @name, @gender, @phoneN, @account)";
        public static string UPDATE_USER_NAME = "UPDATE users SET name = @name WHERE userId = @userId";
        public static string UPDATE_USER_GENDER = "UPDATE users SET gender = @gender WHERE userId = @userId";
        public static string UPDATE_USER_PHONEN = "UPDATE users SET phoneN = @phoneN WHERE userId = @userId";
        public static string DELETE_FROM_USERS = "DELETE FROM users WHERE userId = @userId";



    }


}