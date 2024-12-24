using Npgsql;
using System;

namespace randevu2
{
    public static class DatabaseHelper
    {
        private static readonly string DatabaseConnectionString = "Host=localhost;Port=5432;Database=randevu2;Username=postgres;Password=0000";

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(DatabaseConnectionString);
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı kurulamadı: " + ex.Message);
                throw;
            }
        }
    }
}
