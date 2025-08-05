using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ErisERP
{
    public static class DbHelper
    {
        private static string connectionString = "Server=OKTAY-LENOVO\\SQLEXPRESS;Database=ErisERP_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static Microsoft.Data.SqlClient.SqlConnection GetConnection()
        {
            return new Microsoft.Data.SqlClient.SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
                return false;
            }
        }
    }
}


