using System.Collections.Generic;

namespace ProductApp.Models
{
    public class ProductList
    {
        public List<Product> Products { get; set; }
        public ProductList()
        {
            Products = new List<Product>();
        }
    }
}
