using System;

namespace OfferConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating New Cart");
            PromoEngine promoEngine = new PromoEngine();
            Cart cart = new Cart(promoEngine);

            Product productA = ProductFactory.Instance.Create("A");

            Console.WriteLine("Adding 3 Product A");
            cart.AddItem(productA);
            cart.AddItem(productA);
            cart.AddItem(productA);

            Console.WriteLine($"Cart Value : {cart.CartValue}");

            Product productB = ProductFactory.Instance.Create("B");
            Console.WriteLine("Adding Product B");
            cart.AddItem(productB);

            Console.WriteLine($"Cart Value : {cart.CartValue}");

            Console.WriteLine("Adding Product B");
            cart.AddItem(productB);

            Console.WriteLine($"Cart Value : {cart.CartValue}");

            Console.WriteLine($"Creating New Cart..");
            cart = new Cart(promoEngine);

            Product productC = ProductFactory.Instance.Create("C");
            Product productD = ProductFactory.Instance.Create("D");

            Console.WriteLine("Adding Product C");
            cart.AddItem(productC);

            Console.WriteLine("Adding Product C");
            cart.AddItem(productC);

            Console.WriteLine($"Cart Value : {cart.CartValue}");

            Console.WriteLine("Adding Product D");
            cart.AddItem(productD);

            Console.WriteLine($"Cart Value : {cart.CartValue}");
        }
    }
}
