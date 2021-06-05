using System;

namespace OfferConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating New Cart..");
            PromoEngine promoEngine = new PromoEngine();
            Cart cart = new Cart(promoEngine);

            Product productA = ProductFactory.Instance.Create("A");
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);

            Product productB = ProductFactory.Instance.Create("B");
            cart.AddItem(productB);
            cart.AddItem(productB);

            PrintCartItems(cart);

            Console.WriteLine($"\r\nCreating New Cart..");
            cart = new Cart(promoEngine);

            Product productC = ProductFactory.Instance.Create("C");
            Product productD = ProductFactory.Instance.Create("D");


            cart.AddItem(productC);
            cart.AddItem(productC);

            cart.AddItem(productD);
            cart.AddItem(productD);

            cart.AddItem(productB);
            cart.AddItem(productB);

            PrintCartItems(cart);

            cart.AddItem(productA);
            cart.AddItem(productA);

            PrintCartItems(cart);

            cart.AddItem(productA);
            PrintCartItems(cart);

            Console.WriteLine("Test Cases from PDF");

            Console.WriteLine($"\r\nCreating New Cart..");
            cart = new Cart(promoEngine);
            cart.AddItem(productA);
            cart.AddItem(productB);
            cart.AddItem(productC);
            PrintCartItems(cart);

            Console.WriteLine($"\r\nCreating New Cart..");
            cart = new Cart(promoEngine);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productC);
            PrintCartItems(cart);

            Console.WriteLine($"\r\nCreating New Cart..");
            cart = new Cart(promoEngine);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productB);
            cart.AddItem(productC);
            cart.AddItem(productD);
            PrintCartItems(cart);

        }

        private static void PrintCartItems(Cart cart)
        {
            cart.ApplyPromo();
            Console.WriteLine($"\r\nCartId: {cart.GetHashCode()}");
            Console.WriteLine("Product\tQuantity\tUnit Price\tSelling Price\t");
            Console.WriteLine("==========================================================================");
            foreach (CartItem item in cart.CartItems)
            {
                Console.WriteLine($"{item.Product.Label}\t{item.Quantity}\t\t{item.Product.UnitPrice}\t\t{item.SellingPrice}");
            }
            Console.WriteLine("==========================================================================");
            Console.WriteLine($"Total : {cart.CartValue}");
        }
    }
}
