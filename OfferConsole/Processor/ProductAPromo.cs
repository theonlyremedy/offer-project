using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    /// <summary>
    /// Product A Promo Class
    /// </summary>
    class ProductAPromo : IPromo
    {
        /// <summary>
        /// Constant Values
        /// </summary>
        private struct Const
        {
            public static readonly int PromoPrice = 130;
            public static readonly int PromoQuantity = 3;
            public static readonly string PromoProductLabel = "A";
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
                CartItem promoItem = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel).FirstOrDefault();
                if (promoItem == null)
                    return;

                if (promoItem.Quantity < 3)
                    return;

                int promoQuantity = promoItem.Quantity / Const.PromoQuantity;
                int nonPromoQuantity = promoItem.Quantity % Const.PromoQuantity;
                int sellingPrice = (promoQuantity * Const.PromoPrice) + (nonPromoQuantity * promoItem.Product.UnitPrice);
                promoItem.SellingPrice = sellingPrice;
            }
        }
    }
}
