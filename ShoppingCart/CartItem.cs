﻿namespace ShoppingCart;

public class CartItem
{
    public Product Product { get; }
    private int _count;

    public CartItem(Product product)
    {
        Product = product;
        _count = 1;
    }

    public void SetAmount(int amount)
    {
        _count = amount;
    }
   
    public void CheckoutSelf()
    {
        Console.WriteLine($"{Product.ProductName} x{_count} = {TotalForThisItem()}kr ({Product.ProductPrice}kr stk)");
    }

    public int TotalForThisItem()
    {
        return Product.ProductPrice * _count;
    }
}