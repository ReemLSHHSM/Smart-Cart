using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    internal class GroceryStore
    {
        Product product=new Product();
        ProductGenerator generator=new ProductGenerator();//created instence so i can use the generation method
   
        
        public dynamic food_Product()
        {
            dynamic clothing,food = generator.GenerateProduct();//since this method return 2 hashsets we store in 2 vars

            return food;   //return only food since we are in grocery class
        }



        public void display()
        {
            dynamic food =food_Product();

            foreach (dynamic item in food)
            {
                Console.WriteLine($"Product: {item.Name} \t Price: {item.Price}");
            }
        }

        public dynamic productToAdd(dynamic products)
        {
            dynamic store;
            foreach (dynamic item in products)
            {
                if (products.Contains(item))
                {
                    store = item;
                    Console.WriteLine("Product added to cart successfully :)");
                }
            }
            return 0;
        }
    } 
}
