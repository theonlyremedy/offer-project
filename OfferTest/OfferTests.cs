using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfferConsole;
using System.Linq;

namespace OfferTest
{
    [TestClass]
    public class OfferTests
    {
        PromoEngine promoEngine = new PromoEngine();

        [TestMethod]
        public void TestIsCartEmpty()
        {
            Cart cart = new Cart(promoEngine);
            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product);
            Assert.IsFalse(cart.IsEmpty);
        }

        public void AddItemToCart()
        {
            Cart cart = new Cart(promoEngine);
            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product);
            Product productFromCart = cart.CartItems.Where(x => x.Product == product).FirstOrDefault()?.Product;
            Assert.IsNotNull(productFromCart);
        }

        public void CheckItemQuantity()
        {
            Cart cart = new Cart(promoEngine);
            
            Product product = ProductFactory.Instance.Create("B");
            cart.AddItem(product);

            Product product2 = ProductFactory.Instance.Create("B");
            cart.AddItem(product2);

            CartItem cartItem = cart.CartItems.Where(x => x.Product.Label == product.Label).FirstOrDefault();
            Assert.AreEqual(2, cartItem.Quantity);
        }

        public void CheckItemValue()
        {
            Cart cart = new Cart(promoEngine);

            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product);

            Product product2 = ProductFactory.Instance.Create("A");
            cart.AddItem(product2);

            CartItem cartItem = cart.CartItems.Where(x => x.Product.Label == product.Label).FirstOrDefault();

            Assert.AreEqual(2 * cartItem.Product.UnitPrice, cartItem.SellingPrice);
        }
    }
}
