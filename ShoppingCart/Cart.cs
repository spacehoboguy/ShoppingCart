﻿using System.Collections.Concurrent;

namespace ShoppingCart;

//should contain a list of CartItems
//needs a method to produce and show the Total Price for the Cart as well as price for multiple
//.. of the same item. 
public class Cart

{
    public int TotalPrice { get; private set; }
    public List<CartItem> ShoppingCart { get; set; }

    public Cart()
    {
        ShoppingCart = new List<CartItem>();
        TotalPrice = 0;
    }

    public void Add(CartItem item)
    {
        if (ShoppingCart.Contains(item))
        {
            item.Count++;
        }
        else
        {
            ShoppingCart.Add(item);
        }
    }

    public void Remove(CartItem item)
    {
        if (ShoppingCart.Contains(item) && ShoppingCart[ShoppingCart.IndexOf(item)].Count - 1 > 0)
        {
            ShoppingCart[ShoppingCart.IndexOf(item)].Count--;
        }
        else
        {
            ShoppingCart.Remove(item);
        }

        TotalPrice -= item.Product.ProductPrice * item.Count;
    }

    public void Checkout()
    {
        
        Console.WriteLine("Du kjøpte: \n");
        foreach (var i in ShoppingCart)
        { 
            Console.WriteLine($"{i.Product.ProductName} x{i.Count} = {TotalForThisItem(i)}kr ({i.Product.ProductPrice}kr stk)");
            TotalPrice += i.Product.ProductPrice * i.Count;
        }
        Console.WriteLine($"\nDin total er: {TotalPrice}kr. Thank you for shopping with us!");

    }

    private int TotalForThisItem(CartItem i)
    {
        int total = 0;
        total = i.Product.ProductPrice * i.Count;
        return total;
    }

//private string[] GetCartInfo()
    //{
    //    string[] cart = new string[2];
    //    foreach (var p in Products)
    //    {
    //        if(p.Quantity > 1)
    //        {
    //            cart[0] +=  p.Quantity +"x " + p.ProductName + " - " + (p.ProductPrice * p.Quantity) + " (" + p.ProductPrice + " per)" + "\n";
    //        }
    //        else
    //        {
    //            cart[0] += p.Quantity + "x " + p.ProductName +  " - " + (p.ProductPrice * p.Quantity) + "\n";
    //        }
    //    }
    //    cart[1] += "\n" + TotalPrice + ",-";

    //    return cart;
    //}
}