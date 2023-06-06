using ShoppingCart;
//need 3 classes
void PhilipShoppingCartDemo ()
        {
            Product apple = new Product("Apple", 15);
            Product orange = new Product("Orange", 12);

            Cart myShoppingCart = new Cart();
            myShoppingCart.Add(apple);
            myShoppingCart.Add(apple);
            myShoppingCart.Add(orange); 
            Console.WriteLine(myShoppingCart.Checkout());
        }

PhilipShoppingCartDemo();


//SimpleShoppingCartDemo.Run();

