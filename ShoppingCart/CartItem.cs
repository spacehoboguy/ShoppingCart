namespace ShoppingCart;

public class CartItem
{
    public Product Product { get; }
    private int _count;

    public CartItem(Product product)
    {
        Product = product; 
        // removed count initialize to 1 for each item.
        //_count is set by SetAmount().
    }

    public void SetAmount(int amount)
    {
        _count += amount;
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