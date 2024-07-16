using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static Smart_Cart.Product;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        List<string> clothingProducts = new List<string>
        {
            "T-Shirt",
            "Jeans",
            "Jacket",
            "Sweater",
            "Dress",
            "Shorts",
            "Skirt",
            "Blouse",
            "Socks",
            "Hat"
        };

        List<string> groceryProducts = new List<string>
        {
            "Apple",
            "Orange",
            "Bread",
            "Chicken",
            "Milk",
            "Cheese",
            "Rice",
            "Pasta",
            "Yogurt",
            "Potato"
        };

        List<decimal> prices = new List<decimal>
        {
            1.49m, 
            1.99m, 
            2.49m, 
            7.99m, 
            3.49m, //till here are food prices
            19.99m, 
            49.99m, 
            89.99m, 
            39.99m, 
            59.99m, 
        };

        HashSet<string> food_names;
        HashSet<string> clothes_names ;

        HashSet<Product> clothing = new HashSet<Product>();
        HashSet<Product> food = new HashSet<Product>();

        Random rand = new Random();


        public (HashSet<Product> clothing, HashSet<Product> food) GenerateProduct()
        {
           food_names = new HashSet<string>();
           clothes_names = new HashSet<string>();

      
            while (food_names.Count < 5)
            {
                if (!food_names.Contains(groceryProducts[rand.Next(groceryProducts.Count)])){
                    food_names.Add(groceryProducts[rand.Next(groceryProducts.Count)]);
                }
                
            }

            while (clothes_names.Count < 5)
            {
                if (!clothes_names.Contains(clothingProducts[rand.Next(clothingProducts.Count)]))
                {
                    clothes_names.Add(clothingProducts[rand.Next(clothingProducts.Count)]);
                }
            }


            foreach (var food_name in food_names)
            {
                if (food.Count < 5)
                {
                    food.Add(new Product
                    {
                        Name = food_name,
                        Price = prices[rand.Next(0, 5)],
                        Category = Product.ProductCategory.Food
                    });
                }
                   
                
                
            }

            foreach (var clothes_name in clothes_names)
            {
                if (clothing.Count < 5)
                {
                    clothing.Add(new Product
                    {
                        Name = clothes_name,
                        Price = prices[rand.Next(5, prices.Count)],
                        Category = Product.ProductCategory.Clothing
                    });
                }
                
            }

            return (clothing, food);
        }

         


    }
}