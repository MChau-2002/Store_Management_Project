using System.Data.SqlClient;

namespace StoreManagement.Functions
{
    class Connection
    {
        private static readonly string ConnectionString = @"Data Source=LENOVOSLIM5\MCHAU;Initial Catalog=StoreManagement;Integrated Security=True";
        
        public static SqlConnection Getconnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
