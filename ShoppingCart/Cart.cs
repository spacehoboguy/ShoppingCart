namespace ShoppingCart;

public class Cart

{
    public int TotalPrice { get; private set; }
    public List<CartItem> ShoppingCart { get;}

    public Cart()
    {
        ShoppingCart = new List<CartItem>();
        TotalPrice = 0;
    }

    public void Buy(Product product, int amount)
    {

        var existingItem = ShoppingCart.FirstOrDefault(item => item.Product == product);

        if (existingItem == null)
        {
            var newCartItem = new CartItem(product);
            newCartItem.IncreaseAmount(amount);
            ShoppingCart.Add(newCartItem);
        }
        else existingItem.IncreaseAmount(amount);
    }

    public void Checkout()
    {
        if (ShoppingCart.Count == 0)
        {
            Console.WriteLine("Din Handlekurv er tom.");
        }
        else
        {
            Console.WriteLine("Din Handlekurv: \n");
            foreach (var i in ShoppingCart)
            {
                i.CheckoutSelf();
                TotalPrice += i.TotalForThisItem();
            }

            Console.WriteLine($"\nDin total er: {TotalPrice}kr.\nThank you for shopping with us!");
        }
    }
} 