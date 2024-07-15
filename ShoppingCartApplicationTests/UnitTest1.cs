using  Smart_Cart;
using System;
using System.Collections.Generic;
using Xunit;
using Smart_Cart;

namespace ShoppingCartApplicationTests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void TestCalculateTotal()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            List<Product> items = new List<Product>
            {
                new Product { Name = "T-Shirt", Price = 19.99m },
                new Product { Name = "Apple", Price = 1.49m },
                new Product { Name = "Jeans", Price = 49.99m }
            };

            // Act
            float total = cart.Calculate_Total(items);

            // Assert
            Assert.Equal(71.47f, total); 
        }

        [Fact]
        public void TestAddToCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            string store = "grocerystore"; 

            // Act
            cart.AddtoCart(store);

            // Assert
            Assert.Single(cart.Cart); 
        }

        [Fact]
        public void TestRemoveFromCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            string store = "grocerystore"; 
            cart.AddtoCart(store); // Add an item 
            string itemName = cart.Cart[0].Name;

            // Act
            cart.RemovefromCart(itemName);

            // Assert
            Assert.Empty(cart.Cart); 
        }
    }
}
