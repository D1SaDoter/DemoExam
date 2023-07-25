using Podgotovka.DAL.Repository;
using Podgotovka.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.Service
{
    public class Lists
    {
        RoleRepository roleRepository=new RoleRepository();
        UserRepository userRepository=new UserRepository();
        ProductRepository productRepository=new ProductRepository();
        public List<Role> roles = new List<Role>();
        public List<User> users=new List<User>();
        public List<Product> products=new List<Product>();
        public void GetRole()
        {
            roles = roleRepository.GetAll(roles);
        }
        public void GetUser()
        {
            users = userRepository.GetAll(users);
        }
        public void GetProduct()
        {
            products=productRepository.GetAll(products);
        }
        public void DeleteProduct(int id)
        {
            productRepository.ProductDelete(id);
        }
    }
}
