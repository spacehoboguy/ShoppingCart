using Microsoft.VisualBasic;

namespace ShoppingCart;

public class CartItem
{
    public Product Product { get; }
    public int Count { get; private set; }
    private int TotalPriceForItem { get; set; }

    public CartItem(Product product)
    {
        Product = product;
        Count = 1;
    }

    public void SetAmount(int amount)
    {
        Count=amount;
    }
   
    public void CheckoutSelf()
    {
        Console.WriteLine($"{Product.ProductName} x{Count} = {TotalForThisItem()}kr ({Product.ProductPrice}kr stk)");
        TotalPriceForItem = TotalForThisItem();
    }
    private int TotalForThisItem()
    {
        int total = 0;
        total = Product.ProductPrice * Count;
        return total;
    }
}