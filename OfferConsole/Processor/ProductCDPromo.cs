using System;
using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    /// <summary>
    /// Product C & D Promo Class
    /// </summary>
    class ProductCDPromo : IPromo
    {
        /// <summary>
        /// Constant
        /// </summary>
        private struct Const
        {
            public static readonly int PromoPrice = 30;
            public static readonly int PromoQuantity = 1;
            public static readonly string PromoProductLabel_C = "C";
            public static readonly string PromoProductLabel_D = "D";
        }

        /// <summary>
        /// Process Promo on CartItemsList
        /// </summary>
        public void ProcessCart(List<CartItem> cartItems)
        {
            if (cartItems == null || cartItems.Count == 0)
                return;
            else
            {
                CartItem promoItem_C = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel_C).FirstOrDefault();
                CartItem promoItem_D = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel_D).FirstOrDefault();

                if (promoItem_C == null && promoItem_D == null)
                    return;

                int promoQuantity = Math.Min(promoItem_C?.Quantity ?? 0, promoItem_D?.Quantity ?? 0);
                
                if (promoItem_C != null)
                {
                    int nonPromoQuantity_C = promoItem_C.Quantity- promoQuantity;
                    int sellingPrice_C = ((promoQuantity * Const.PromoPrice) / 2) + (nonPromoQuantity_C * promoItem_C.Product.UnitPrice);
                    promoItem_C.SellingPrice = sellingPrice_C;
                }

                if (promoItem_D != null)
                {
                    int nonPromoQuantity_D = promoItem_D.Quantity - promoQuantity;
                    int sellingPrice_D = ((promoQuantity * Const.PromoPrice) / 2) + (nonPromoQuantity_D * promoItem_D.Product.UnitPrice);
                    promoItem_D.SellingPrice = sellingPrice_D;
                }
            }
        }
    }
}
