using System;
using System.Collections.Generic;

namespace Smart_Cart
{
    internal class ClothingStore
    {
        ProductGenerator generator = new ProductGenerator();

        public HashSet<Product> clothing_Product()
        {
            return generator.GenerateProduct().clothing;
        }

        public void display()
        {
            HashSet<Product> clothing = clothing_Product();

            foreach (Product item in clothing)
            {
                Console.WriteLine($"Product: {item.Name} \t Price: {item.Price}");
            }
        }

        public Product productToAdd(HashSet<Product> products, string product)
        {
            foreach (Product item in products)
            {
                if (item.Name.ToLower() == product.ToLower())
                {
                    Console.WriteLine("Product added to cart successfully :)\n");
                    return item;
                }
            }

            Console.WriteLine("Product doesn't exist at the moment :(\n");
            return null;
        }

        public Product Add()
        {
            HashSet<Product> clothing = clothing_Product();
            Console.WriteLine("What product would you like to add? \n");
            display();
            Console.WriteLine();
            string product = Console.ReadLine();
            return productToAdd(clothing, product);
        }
    }
}
