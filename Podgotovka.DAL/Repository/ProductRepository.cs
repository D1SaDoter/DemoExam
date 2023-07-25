using MySql.Data.MySqlClient;
using Podgotovka.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.DAL.Repository
{
    public class ProductRepository
    {
        ConnectionString connectString = new ConnectionString();
        public List<Product> GetAll(List<Product> product)
        {
            MySqlDataReader itemsQuery = connectString.Connection("SELECT * FROM Product");
            product.Clear();
            while (itemsQuery.Read())
            {
                Product newItem = new Product();
                newItem.Id = Convert.ToInt32(itemsQuery.GetValue(0));
                newItem.ProductArticleNumber = Convert.ToString(itemsQuery.GetValue(1));
                newItem.ProductName = Convert.ToString(itemsQuery.GetValue(2));
                newItem.ProductDescription = Convert.ToString(itemsQuery.GetValue(3));
                newItem.ProductCategory = Convert.ToString(itemsQuery.GetValue(4));
                newItem.ProductPhoto = Convert.ToString(itemsQuery.GetValue(5));
                newItem.ProductManufacturer = Convert.ToString(itemsQuery.GetValue(6));
                newItem.ProductProvider = Convert.ToString(itemsQuery.GetValue(7));
                newItem.ProductCost = Convert.ToDecimal(itemsQuery.GetValue(8));
                newItem.ProductDiscountAmount = Convert.ToInt32(itemsQuery.GetValue(9));
                newItem.ProductMaxDiscount = Convert.ToInt32(itemsQuery.GetValue(10));
                newItem.ProductQuantityInStock = Convert.ToInt32(itemsQuery.GetValue(11));
                newItem.ProductUnit = Convert.ToString(itemsQuery.GetValue(12));


                product.Add(newItem);
            }
            return product;
        }
        public void ProductDelete(int id)
        {
            connectString.Connection("DELETE FROM `Product` WHERE id=" + id);
        }
    }
}
