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
            Cart cart = new Cart();
            Product product = ProductFactory.Create("A");
            cart.Add()
        }
    }
}
