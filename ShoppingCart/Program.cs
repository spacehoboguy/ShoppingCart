using ShoppingCart;

//Skriv mer objektorientert,trekke ut de rette klassene
//innkapsling, dvs. bruk mest mulig private objektvariable
//programmet skal gjøre akkurat det samme som må
//dette blir istedenfor en ny codealong.
//Send meg github-lenke når du er 60%-80% ferdig

//need 3 classes
//Det er fint å trekke ut Product og Cart som klasser.
//Men det kan dras enda lenger. Istedenfor to separate lister for Counts og Products,
//så kan du lage en klasse CartItem som har både et produkt og et antall.
//Da kan du klare deg med en liste i Cart - en liste av CartItems.
//Innholdet av løkka i ShowCart kan du da trekke ut som en metode som hører hjemme i CartItem. 

void ShoppingCartDemo ()
        {
            //initialize products in store
            var apple = new Product("Apple", 15);
            var orange = new Product("Orange", 12);
            var mango = new Product("Mango", 20);

            //initialize a cart for user
            var myShoppingCart = new Cart();

            //initializing cartItems, could be better maybe?
            var a = new CartItem(apple); 
            var b = new CartItem(orange); 
            var c = new CartItem(mango);

            //user adding items to their cart
            myShoppingCart.Add(a);
            myShoppingCart.Add(a);
            myShoppingCart.Add(b);
            myShoppingCart.Add(b);
            myShoppingCart.Add(a);
            myShoppingCart.Add(c);

            //user checking out cart
            myShoppingCart.Checkout();
        }

ShoppingCartDemo();


//SimpleShoppingCartDemo.Run();

