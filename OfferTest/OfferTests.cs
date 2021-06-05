using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfferConsole;
using System.Linq;

namespace OfferTest
{
    [TestClass]
    public class OfferTests
    {
        #region Field
        PromoEngine promoEngine = new PromoEngine();
        #endregion

        #region TestMethod
        [TestMethod]
        public void TestIsCartEmpty()
        {
            Cart cart = new Cart(promoEngine);
            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product);
            Assert.IsFalse(cart.IsEmpty);
        }

        [TestMethod]
        public void AddItemToCart()
        {
            Cart cart = new Cart(promoEngine);
            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product);
            Product productFromCart = cart.CartItems.Where(x => x.Product == product).FirstOrDefault()?.Product;
            Assert.IsNotNull(productFromCart);
        }

        [TestMethod]
        public void CheckItemQuantity()
        {
            Cart cart = new Cart(promoEngine);
            
            Product product = ProductFactory.Instance.Create("B");
            cart.AddItem(product, 2);

            CartItem cartItem = cart.CartItems.Where(x => x.Product.Label == product.Label).FirstOrDefault();
            Assert.AreEqual(2, cartItem.Quantity);
        }

        [TestMethod]
        public void CheckItemValue()
        {
            Cart cart = new Cart(promoEngine);

            Product product = ProductFactory.Instance.Create("A");
            cart.AddItem(product, 2);

            CartItem cartItem = cart.CartItems.Where(x => x.Product.Label == product.Label).FirstOrDefault();

            Assert.AreEqual(2 * cartItem.Product.UnitPrice, cartItem.SellingPrice);
        }

        [TestMethod]
        public void CheckSellingPriceAfterOffer()
        {
            Cart cart = new Cart(promoEngine);

            Product product = ProductFactory.Instance.Create("B");
            cart.AddItem(product, 2);

            CartItem cartItem = cart.CartItems.Where(x => x.Product.Label == product.Label).FirstOrDefault();
            Assert.AreEqual(45, cart.CartValue);
        }
        #endregion
    }
}
