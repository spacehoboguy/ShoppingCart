namespace ShoppingCart;

public class CartItem //should contain Product and ProductCount
{
    public Product Product { get; }
    public int Count { get; set; }
    private int TotalPriceForItem { get; set; }

    public CartItem(Product product)
    {
        Product = product;
        Count = 1;
    }

    public void Buy(CartItem item, int amount)
    {
        if (item.Count>0)
        {
            item.Count++;
        }
        else
        {
            ShoppingCart.Add();
        }
    }

    private void CheckoutSelf()
    {
        Console.WriteLine($"{Product.ProductName} x{Count} = {TotalForThisItem()}kr ({Product.ProductPrice}kr stk)");
    }
    private int TotalForThisItem()
    {
        int total = 0;
        total = Product.ProductPrice * Count;
        return total;
    }
}