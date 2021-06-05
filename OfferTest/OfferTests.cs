using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfferConsole;

namespace OfferTest
{
    [TestClass]
    public class OfferTests
    {
        [TestMethod]
        public void TestIsCartEmpty()
        {
            PromoEngine promoEngine = new PromoEngine();
            Cart cart = new Cart(promoEngine);
            Product product = ProductFactory.Create("A");
            cart.AddItem(product);
            Assert.IsFalse(cart.IsEmpty);
        }
    }
}
