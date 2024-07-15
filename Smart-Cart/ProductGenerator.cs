using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        private List<string> clothingProducts = new List<string>
        {
            "T-Shirt", "Jeans", "Jacket", "Sweater", "Dress",
            "Shorts", "Skirt", "Blouse", "Socks", "Hat"
        };

        private List<string> groceryProducts = new List<string>
        {
            "Apple", "Orange", "Bread", "Chicken", "Milk",
            "Cheese", "Rice", "Pasta", "Yogurt", "Potato"
        };

        private List<decimal> prices = new List<decimal>
        {
            // Prices for food items
            1.49m, 1.99m, 2.49m, 7.99m, 3.49m,

            // Prices for clothing items
            19.99m, 49.99m, 89.99m, 39.99m, 59.99m
        };

        private Random rand = new Random();

        // Helper method to generate unique random indices
        private List<int> GetUniqueRandomIndices(int count, int max)
        {
            return Enumerable.Range(0, max).OrderBy(x => rand.Next()).Take(count).ToList();
        }

        public (HashSet<Product> clothing, HashSet<Product> food) GenerateProduct()
        {
            HashSet<Product> clothingSet = new HashSet<Product>();
            HashSet<Product> foodSet = new HashSet<Product>();

            // Get unique random indices for clothing and food products
            List<int> clothingIndices = GetUniqueRandomIndices(5, clothingProducts.Count);
            List<int> foodIndices = GetUniqueRandomIndices(5, groceryProducts.Count);
            List<int> clothingPriceIndices = GetUniqueRandomIndices(5, prices.Count - 5).Select(x => x + 5).ToList(); // Adjust for clothing price indices
            List<int> foodPriceIndices = GetUniqueRandomIndices(5, 5); // First 5 for food prices

            // Generate unique clothing products
            for (int i = 0; i < 5; i++)
            {
                string productName = clothingProducts[clothingIndices[i]];
                decimal productPrice = prices[clothingPriceIndices[i]];

                Product newClothing = new Product()
                {
                    Name = productName,
                    Price = productPrice,
                    Category = Product.ProductCategory.Clothing
                };

                clothingSet.Add(newClothing);
            }

            // Generate unique food products
            for (int i = 0; i < 5; i++)
            {
                string productName = groceryProducts[foodIndices[i]];
                decimal productPrice = prices[foodPriceIndices[i]];

                Product newFood = new Product()
                {
                    Name = productName,
                    Price = productPrice,
                    Category = Product.ProductCategory.Food
                };

                foodSet.Add(newFood);
            }

            return (clothingSet, foodSet);
        }
    }
}
