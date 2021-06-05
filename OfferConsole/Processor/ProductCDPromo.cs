using System;
using System.Collections.Generic;
using System.Linq;

namespace OfferConsole.Processor
{
    class ProductCDPromo : IPromo
    {
        private struct Const
        {
            public static readonly int PromoPrice = 30;
            public static readonly int PromoQuantity = 1;
            public static readonly string PromoProductLabel_C = "C";
            public static readonly string PromoProductLabel_D = "D";
        }

        public void ProcessCart(List<CartItem> cartItems)
        {
            if (cartItems == null || cartItems.Count == 0)
                return;
            else
            {
                CartItem promoItemC = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel_C && !x.OfferApplied).FirstOrDefault();
                CartItem promoItemD = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel_D && !x.OfferApplied).FirstOrDefault();

                if (promoItemC == null && promoItemD == null)
                    return;

                int promoQuantity = Math.Min(promoItemC.Quantity, promoItemD.Quantity);
                int nonPromoQuantity_C = promoItemC.Quantity - promoQuantity;
                int nonPromoQuantity_D = promoItemD.Quantity - promoQuantity;

                if (promoItemC != null)
                {
                    int sellingPrice_C = ((promoQuantity * Const.PromoPrice) / 2) + (nonPromoQuantity_C * promoItemC.Product.UnitPrice);
                    promoItemC.OfferApplied = true;
                    promoItemC.SellingPrice = sellingPrice_C;
                }

                if (promoItemD != null)
                {
                    int sellingPrice_D = ((promoQuantity * Const.PromoPrice) / 2) + (nonPromoQuantity_D * promoItemD.Product.UnitPrice);
                    promoItemD.OfferApplied = true;
                    promoItemD.SellingPrice = sellingPrice_D;
                }
            }
        }
    }
}
