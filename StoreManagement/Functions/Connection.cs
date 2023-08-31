using System.Data.SqlClient;

namespace StoreManagement.Functions
{
    class Connection
    {
        private static string ConnectionString = @"Data Source=DESKTOP-MHFTAB6;Initial Catalog=StoreManagement;Integrated Security=True";
        
        public static SqlConnection Getconnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
