using ShoppingCart;

/*Improvements to make*/
//Istedenfor metoden  Add i Cart, vil jeg ha en metode Buy som tar to parametre: 
// - et produkt og et antall. Så gjør den som nå, endrer eksisterende cart item eller lager nytt.
//Inne i løkken i Checkout: flytt til metode i CartItem.
//Samme med TotalForThisItem - flytt til metode i CartItem
//bruk private objektvariabler så langt du får til.
//Om det ikke går, bruker du public property med kun get, og om ikke det går,
//bruker du public property med private set.
void ShoppingCartDemo ()
        {
            //initialize products in store
            var apple = new Product("Apple", 15);
            var orange = new Product("Orange", 12);
            var mango = new Product("Mango", 20);

            //initialize a cart for user
            var myShoppingCart = new Cart();


            //user adding items to their cart
            myShoppingCart.Buy(apple,1);
            myShoppingCart.Buy(mango, 4);
            myShoppingCart.Buy(orange, 1);
            

            //user checking out cart
            myShoppingCart.Checkout();
        }
ShoppingCartDemo();

