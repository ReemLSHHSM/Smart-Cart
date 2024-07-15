# Smart-Cart

## Overview

Smart-Cart is a console-based application that allows users to shop from two different types of stores: ClothingStore and GroceryStore. Users can add items to their cart, remove items, view their cart, and checkout.

## Features

- Randomly generates a set of products for ClothingStore and GroceryStore.
- Allows users to add, remove, view, and checkout products from their cart.

## Getting Started

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or any C# IDE.
3. Build and run the project.

## Usage

1. Upon starting the application, choose the type of store you want to shop from.
2. Select the service you want to use:
   - Add: Add a product to your cart.
   - Remove: Remove a product from your cart.
   - View: View all products in your cart.
   - Checkout: View the total price and complete your shopping.

## Classes

- **Product**: Represents a product with properties for `Name`, `Price`, and `Category`.
- **ProductGenerator**: Generates random unique products for the stores.
- **ShoppingCart**: Manages the products added to the cart.
- **GroceryStore** and **ClothingStore**: Represent the two types of stores in the mall.
- **Program**: The main entry point for the application.


