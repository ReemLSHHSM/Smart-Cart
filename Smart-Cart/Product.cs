using System;

namespace Smart_Cart
{
    public class Product
    {
        public enum ProductCategory
        {
            Food,
            Clothing,
            Electronics
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
    }
}
