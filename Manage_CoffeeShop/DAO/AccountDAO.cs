using Manage_CoffeeShop.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_CoffeeShop.DAO
{
    internal class AccountDAO
    {
        coffeeContext coffee = new coffeeContext();
        public List<Account> LoadDataAccount()
        {
            /*string sqlconnectStr = "Data Source=localhost,1433;Initial Catalog=coffee;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(sqlconnectStr);
            SqlCommand command = new SqlCommand();
            connection.Open();
            string query = "Select * from dbo.account";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
           */
       
         
            var accounts = coffee.Accounts.ToList();
            return accounts;
        }

        public bool GetAccountByUsernameAndPass(string username,string pass)
        {
            bool rs = false;
            var accounts = coffee.Accounts.ToList();
            try
            {
                Account account = accounts.FirstOrDefault(x => x.Username == username && x.Password == pass);
                if (account != null)
                {
                    rs=true;
                }

            }
            catch(ArgumentNullException e)
            {

            }

            return rs;
        }



    }
}
