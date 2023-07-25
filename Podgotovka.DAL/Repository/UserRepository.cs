using MySql.Data.MySqlClient;
using Podgotovka.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.DAL.Repository
{
    public class UserRepository
    {
        ConnectionString connectString = new ConnectionString();
        public List<User> GetAll(List<User> user)
        {
            MySqlDataReader itemsQuery = connectString.Connection("SELECT * FROM Users");
            user.Clear();
            while (itemsQuery.Read())
            {
                User newItem = new User();
                newItem.UserId = Convert.ToInt32(itemsQuery.GetValue(0));
                newItem.UserSurname = Convert.ToString(itemsQuery.GetValue(1));
                newItem.UserName = Convert.ToString(itemsQuery.GetValue(2));
                newItem.UserPatronymic = Convert.ToString(itemsQuery.GetValue(3));
                newItem.UserLogin = Convert.ToString(itemsQuery.GetValue(4));
                newItem.UserPassword = Convert.ToString(itemsQuery.GetValue(5));
                newItem.UserRole = Convert.ToInt32(itemsQuery.GetValue(6));


                user.Add(newItem);
            }
            return user;
        }
    }
}
