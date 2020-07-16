using System;

namespace ProductApp.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public String Pname { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public Product(int id, String name, float price, int stock)
        {
            Pid = id;
            Pname = name;
            Price = price;
            Stock = stock;
        }
    }
}
