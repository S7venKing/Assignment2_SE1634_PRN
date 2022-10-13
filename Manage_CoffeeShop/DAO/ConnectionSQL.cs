using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_CoffeeShop.DAO
{
    public class ConnectionSQL
    {
        public SqlConnection CreateConnection()
        {
            string sqlconnectStr = "Data Source=localhost,1433;Initial Catalog=coffee;User ID=sa;Password=123456";
            SqlConnection sqlConnection = new SqlConnection(sqlconnectStr);
            return sqlConnection;        
        }
    }
}
