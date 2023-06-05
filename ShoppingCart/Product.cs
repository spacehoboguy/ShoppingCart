namespace ShoppingCart;

public class Product
{
    public string ProductName { get; private set; }
    public int ProductPrice { get; private set; }
    public int Quantity { get; set; }

    public Product(string productName, int productPrice, int quantity = 1)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        Quantity = quantity;
    }
}