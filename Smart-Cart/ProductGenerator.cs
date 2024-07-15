using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        List<string> GroceryProducts = new List<string>
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
    // Prices for food items
    1.49m, 
    1.99m, 
    2.49m, 
    7.99m, 
    3.49m, 

    // Prices for clothing items
    19.99m, 
    49.99m, 
    89.99m,
    39.99m, 
    59.99m, 
};

        HashSet<Product> clothing = new HashSet<Product>();
        HashSet<Product> food = new HashSet<Product>();

        Random rand =new Random();
        public (HashSet<Product> clothing, HashSet<Product> food) GenerateProduct()//could cause an error
        {
            while (clothing.Count < 5 && food.Count < 5)
            {
                //clothing.Add(clothingProducts[rand.Next()]);
                //food.Add(GroceryProducts[rand.Next()]);
                clothing.Add(new Product() { Name = clothingProducts[rand.Next()], Price = prices[rand.Next(5,prices.Count)],Category=ProductCategory.Clothing });
                food.Add(new Product() { Name = GroceryProducts[rand.Next()], Price = prices[rand.Next(0,5)], Category = ProductCategory.Food });
            }

            return (clothing, food);
        }

    }
}
