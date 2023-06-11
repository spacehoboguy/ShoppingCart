using System.Collections.Concurrent;

namespace ShoppingCart;

public class Cart

{
    public int TotalPrice { get; private set; }
    public List<CartItem?> ShoppingCart { get; }

    public Cart()
    {
        ShoppingCart = new List<CartItem?>();
        TotalPrice = 0;
    }

    public void Buy(Product product, int amount)
    {
        CartItem? existingItem = ShoppingCart.FirstOrDefault(item => item.Product == product);

        if (existingItem == null)
        {
            CartItem? newCartItem = new CartItem(product);
            newCartItem.SetAmount(amount);
            ShoppingCart.Add(newCartItem);
        }
        else
        {
            existingItem.SetAmount(amount);
        }
    }

    public void Checkout()
    {

        Console.WriteLine("Du kjøpte: \n");
        foreach (var i in ShoppingCart)
        {
            i?.CheckoutSelf();
            TotalPrice += TotalForThisItem(i);
        }

        Console.WriteLine($"\nDin total er: {TotalPrice}kr.\nThank you for shopping with us!");

    }

    internal int TotalForThisItem(CartItem item) 
    {
        int total = 0;
        total = item.Product.ProductPrice * item.Count;
        return total;
    }
}