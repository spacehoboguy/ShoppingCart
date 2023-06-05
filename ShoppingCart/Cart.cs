using System.Collections.Concurrent;

namespace ShoppingCart;

public class Cart
{
    public int TotalPrice { get; private set; }
    public List<Product> Products { get; private set; }

    public Cart()
    {
        Products = new List<Product>();
    }

    public void Add(Product product)
    {
        if (Products.Contains(product))
        {
            product.Quantity++;
        }
        else
        {
            Products.Add(product);
        }

        TotalPrice += product.ProductPrice * product.Quantity;
    }

    public void Remove(Product product)
    {
        if (Products.Contains(product) && Products[Products.IndexOf(product)].Quantity - 1 > 0)
        {
            Products[Products.IndexOf(product)].Quantity--;
        }
        else
        {
            Products.Remove(product);
        }
        TotalPrice -= product.ProductPrice * product.Quantity;
    }

    public string Checkout()
    {
        var cartInfo = GetCartInfo();
        return "Du kjøpte:\n" + cartInfo[0] + "\n\n" + "Det kostet deg: " + cartInfo[1];
    }

    private string[] GetCartInfo()
    {
        string[] cart = new string[2];
        foreach (var p in Products)
        {
            if(p.Quantity > 1)
            {
                cart[0] +=  p.Quantity +"x " + p.ProductName + " - " + (p.ProductPrice * p.Quantity) + " (" + p.ProductPrice + " per)" + "\n";
            }
            else
            {
                cart[0] += p.Quantity + "x " + p.ProductName +  " - " + (p.ProductPrice * p.Quantity) + "\n";
            }
        }
        cart[1] += "\n" + TotalPrice + ",-";

        return cart;
    }
}