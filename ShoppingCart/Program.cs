using ShoppingCart;

    var apple = new Product("Apple", 15);
    var orange = new Product("Orange", 12);
    var mango = new Product("Mango", 20);
    var myShoppingCart = new Cart();
    myShoppingCart.Buy(apple,1);
    myShoppingCart.Buy(apple,2);
    myShoppingCart.Buy(mango, 4);
    myShoppingCart.Buy(apple, 4);
    myShoppingCart.Buy(orange, 1);
    myShoppingCart.Checkout();