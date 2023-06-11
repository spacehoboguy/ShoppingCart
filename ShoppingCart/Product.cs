namespace ShoppingCart;

//should contain the ProductName and Price
public class Product

{
    public string ProductName { get; }

    public int ProductPrice {get; }
    //public int Quantity { get; set; }

    public Product(string productName, int productPrice)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        //Quantity = quantity;
    }
}