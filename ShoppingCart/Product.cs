namespace ShoppingCart;

public class Product

{
    public string ProductName { get; }
    public int ProductPrice {get; }

    public Product(string productName, int productPrice)
    {
        ProductName = productName;
        ProductPrice = productPrice;
    }
}