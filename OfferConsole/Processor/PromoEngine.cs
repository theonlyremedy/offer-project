using System;
using System.Collections.Generic;

namespace OfferConsole
{
    public class PromoEngine
    {
        List<IPromo> promoList = null;

        public PromoEngine()
        {
            promoList = new List<IPromo>()
            {
               new ProductAPromo(),
               new ProductBPromo(),
               new ProductCDPromo()
            };
        }

        internal void ApplyPromo(List<CartItem> cartItems)
        {
            foreach(IPromo promo in promoList)
            {
                promo.ProcessCart(cartItems);
            }
        }
    }
}
