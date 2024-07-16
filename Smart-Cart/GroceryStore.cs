using System;
using System.Collections.Generic;

namespace Smart_Cart
{
    internal class GroceryStore
    {
        ProductGenerator generator = new ProductGenerator();

        public HashSet<Product> food_Product()
        {
            return generator.GenerateProduct().food;
        }

        public void display()
        {
            HashSet<Product> food = food_Product();

            foreach (Product item in food)
            {
                Console.WriteLine($"Product: {item.Name}\tPrice: {item.Price}");
            }
        }

        public Product productToAdd(HashSet<Product> products, string product)
        {
            foreach (Product item in products)
            {
                if (item.Name.ToLower() == product.ToLower())
                {
                    Console.WriteLine("Product added to cart successfully :)");
                    return item;
                }
            }

            Console.WriteLine("Product doesn't exist at the moment");
            return null;
        }

        public Product Add()
        {
            HashSet<Product> food = food_Product();
            Console.WriteLine("What product would you like to add? \n");
            display();
            Console.WriteLine();
            string product = Console.ReadLine();
            return productToAdd(food, product);
        }

        
    }
}
