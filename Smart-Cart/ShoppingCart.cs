using System;
using System.Collections.Generic;

namespace Smart_Cart
{
    public class ShoppingCart
    {
       public List<Product> Cart = new List<Product>(); // for storing items in cart

        ClothingStore Store = new ClothingStore();
        GroceryStore grocery = new GroceryStore();

        public void AddtoCart(string store)
        {
            if (store.ToLower() == "grocerystore")
            {
                dynamic item = grocery.Add();
                if (item != null)
                {
                    Cart.Add(item);
                }
            }
            else if (store.ToLower() == "clothingstore")
            {
                dynamic item = Store.Add();
                if (item != null)
                {
                    Cart.Add(item);
                }
            }
            else
            {
                Console.WriteLine("This store doesn't exist\n");
            }
        }

        public void RemovefromCart(string item)
        {
            if (Cart.Count > 0)
            {
                bool found = false;
                for (int i = Cart.Count - 1; i >= 0; i--)
                {
                    if (Cart[i].Name.ToLower() == item.ToLower())
                    {
                        Cart.RemoveAt(i);
                        found = true;
                        Console.WriteLine("Product removed successfully :) \n");
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Sorry, Product not in cart :< \n");
                }
            }
            else
            {
                Console.WriteLine("Your cart is empty :< \n");
            }
        }

        public void ViewCart()
        {
            if (Cart.Count > 0)
            {
                Console.WriteLine($"You currently have a total number of products of: {Cart.Count}\n");
                Console.WriteLine("Your Cart consists of the following products: \n");
                foreach (dynamic product in Cart)
                {
                    Console.WriteLine($"Name: {product.Name.ToUpper()}\t Price: {product.Price}$ \n");
                }

                Console.WriteLine("Would you like to remove any of the products? \n");
                string answer = Console.ReadLine();
                while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Invalid input, please try again :< \n");
                    Console.WriteLine("Would you like to remove any of the products? \n");
                    answer = Console.ReadLine();
                }

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("What product do you want to remove? \n");
                    string result = Console.ReadLine();
                    RemovefromCart(result);
                }
            }
            else
            {
                Console.WriteLine("Your cart is empty :< \n");
            }
            
        }

        public float Calculate_Total(dynamic items) // to make testing easy
        {
            float sum = 0;
            foreach (dynamic item in items)
            {
                if (item != null)
                {
                    sum += (float)item.Price;
                }
            }
            return sum;
        }

        public float Total() // use this
        {
            float sum = Calculate_Total(Cart);
            Console.WriteLine($"Your total is: {sum}\n");
            return sum;
        }
    }
}
