using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DomesoSystem.Data
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
            @"Data Source=localhost;Initial Catalog=DomesoSystemDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
