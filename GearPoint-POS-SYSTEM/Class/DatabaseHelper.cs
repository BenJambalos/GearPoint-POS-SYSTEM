using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearPoint_POS_SYSTEM
{
    internal static class DatabaseHelper
    {
        private static string connectionString = "server=localhost;database=gearpointdb;uid=root;pwd=@dmin_123;";

        // For INSERT, UPDATE, DELETE
        public static void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                foreach (var p in parameters)
                    cmd.Parameters.AddWithValue(p.Key, p.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ For SELECT queries (loading data)
        public static DataTable GetDataTable(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                conn.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
