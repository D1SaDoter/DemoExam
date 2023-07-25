using MySql.Data.MySqlClient;
using Podgotovka.Domain;
using Podgotovka.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.DAL.Repository
{
    public class RoleRepository
    {
        ConnectionString connectString = new ConnectionString();
        public List<Role> GetAll(List<Role> role)
        {
            MySqlDataReader itemsQuery = connectString.Connection("SELECT * FROM Role");
            role.Clear();
            while (itemsQuery.Read())
            {
                Role newItem = new Role();
                newItem.RoleId = Convert.ToInt32(itemsQuery.GetValue(0));
                newItem.RoleName = Convert.ToString(itemsQuery.GetValue(1));


                role.Add(newItem);
            }
            return role;
        }
    }
}
