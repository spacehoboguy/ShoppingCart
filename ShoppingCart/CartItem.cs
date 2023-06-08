namespace ShoppingCart;

public class CartItem //should contain Product and ProductCount
{
    public Product Product { get; }
    public int Count { get; set; }

    public CartItem(Product product)
    {
        Product = product;
        Count = 1;
    }
}