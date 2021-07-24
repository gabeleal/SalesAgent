using System;

namespace SalesAgent.Entities
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }

        public Product(string productId, string name, double price, string category, int stock)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Category = category;
            Stock = stock;
        }
    }
}