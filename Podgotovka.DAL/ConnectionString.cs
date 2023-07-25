using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.DAL
{
    public class ConnectionString
    {
        
        public MySqlDataReader Connection(string query)
        {
            string connectionString = "server=localhost;user=root;port=3346;database=trade;";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            myConnection.Open();

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
