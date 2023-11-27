using System.Data.SqlClient;

namespace StoreManagement.Functions
{
    class Connection
    {
        private static readonly string ConnectionString = @"Data Source=DESKTOP-MHFTAB6;Initial Catalog=StoreManagement3;Integrated Security=True";
        
        public static SqlConnection Getconnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
