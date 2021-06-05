using System;
using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    public class Cart
    {
        private PromoEngine promoEngine;
        public bool IsEmpty { get; private set; }

        public List<CartItem> CartItems { get; private set; }
        public int CartValue { get { return promoEngine.ComputeCartValue(CartItems); }  }

        public Cart(PromoEngine promoEngine)
        {
            CartItems = new List<CartItem>();
            this.promoEngine = promoEngine;
        }

        public void AddItem(Product product)
        {
            CartItem cartItem = CartItems.FirstOrDefault(x => x.Product.Label == product.Label);
            if (cartItem == null)
                cartItem = new CartItem(product);
            else
                cartItem.Quantity++;
        }
    }
}