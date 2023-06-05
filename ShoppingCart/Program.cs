using ShoppingCart;
//need 3 classes
Console.OutputEncoding = System.Text.Encoding.UTF8;

Product apple = new Product("Apple", 15);
Product orange = new Product("Orange", 12);

Cart myShoppingCart = new Cart();
myShoppingCart.Add(apple);
myShoppingCart.Add(apple);
myShoppingCart.Add(orange);
Console.WriteLine(myShoppingCart.Checkout()); 
//SimpleShoppingCartDemo.Run();