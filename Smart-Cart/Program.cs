using System;

namespace Smart_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroceryStore store = new GroceryStore();
            ClothingStore clothingstore = new ClothingStore();
            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("Welcome to E-Mall\n");
            Console.WriteLine("What type of shopping would you like to do?\n");
            Console.WriteLine("Choose the shop name\n[1]ClothingStore\t[2]GroceryStore\n");

            string answer = Console.ReadLine();
            Console.WriteLine();

            while (answer.ToLower() != "clothingstore" && answer.ToLower() != "grocerystore")
            {
                Console.WriteLine("E-Mall hasn't opened this store yet, try again\n");
                Console.WriteLine("What type of shopping would you like to do?\n");
                Console.WriteLine("Choose the shop name([1]ClothingStore\n[2]GroceryStore)\n");
                answer = Console.ReadLine();
                Console.WriteLine();
            }

            if (answer.ToLower() == "clothingstore")
            {
                Console.WriteLine("ClothingStore has the following products: \n");
                clothingstore.display();
                Console.WriteLine("What service would you like to have?\n");
                Console.WriteLine("[1]Add\t[2]Remove\t[3]View\t[4]Checkout\n");

                string service = Console.ReadLine();
                Console.WriteLine();

                while (service.ToLower() != "checkout")
                {
                    HandleService(cart, service, "ClothingStore");

                    Console.WriteLine("What service would you like to have?\n");
                    Console.WriteLine("[1]Add\t[2]Remove\t[3]View\t[4]Checkout\n");
                    service = Console.ReadLine();
                    Console.WriteLine();
                }

                if (service.ToLower() == "checkout")
                {
                    cart.Total();
                    Console.WriteLine("Thank you for shopping at E-Mall till next time :) \n");
                    Environment.Exit(0);
                }
            }
            else if (answer.ToLower() == "grocerystore")
            {
                Console.WriteLine("GroceryStore has the following products: \n");
                store.display();
                Console.WriteLine();
                Console.WriteLine("What service would you like to have?\n");
                Console.WriteLine("[1]Add\t[2]Remove\t[3]View\t[4]Checkout");

                string service = Console.ReadLine();
                Console.WriteLine();

                while (service.ToLower() != "checkout")
                {
                    HandleService(cart, service, "GroceryStore");

                    Console.WriteLine("What service would you like to have?\n");
                    Console.WriteLine("[1]Add\t[2]Remove\t[3]View\t[4]Checkout");
                    service = Console.ReadLine();
                    Console.WriteLine();
                }

                if (service.ToLower() == "checkout")
                {
                    cart.Total();
                    Console.WriteLine("Thank you for shopping at E-Mall till next time :) \n");
                    Environment.Exit(0);
                }
            }
        }

        static void HandleService(ShoppingCart cart, string service, string store)
        {
            switch (service.ToLower())
            {
                case "add":
                    cart.AddtoCart(store);
                    cart.Total();
                    break;
                case "remove":
                    Console.WriteLine("What product do you want to remove? \n");
                    string result = Console.ReadLine();
                    Console.WriteLine();
                    cart.RemovefromCart(result);
                    cart.Total();
                    break;
                case "view":
                    cart.ViewCart();
                    cart.Total();
                    break;
                case "checkout":
                    cart.Total();
                    Console.WriteLine("Thank you for shopping at E-Mall till next time :) \n");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid service choice. Please choose again.\n");
                    break;
            }
        }
    }
}
