using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.Domain.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductPhoto { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductProvider { get; set; }
        public decimal ProductCost { get; set; }
        public int ProductDiscountAmount { get; set; }
        public int ProductMaxDiscount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductUnit { get; set; }
    }
}
