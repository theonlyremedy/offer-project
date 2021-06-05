using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    /// <summary>
    /// Product B Promo Class
    /// </summary>
    class ProductBPromo : IPromo
    {
        /// <summary>
        /// Constant
        /// </summary>
        private struct Const
        {
            public static readonly int PromoPrice = 45;
            public static readonly int PromoQuantity = 2;
            public static readonly string PromoProductLabel = "B";
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

                int promoQuantity = promoItem.Quantity / Const.PromoQuantity;
                int nonPromoQuantity = promoItem.Quantity % Const.PromoQuantity;
                int sellingPrice = (promoQuantity * Const.PromoPrice) + (nonPromoQuantity * promoItem.Product.UnitPrice);
                promoItem.SellingPrice = sellingPrice;
            }
        }
    }
}
