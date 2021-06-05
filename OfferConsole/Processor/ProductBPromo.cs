using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    class ProductBPromo : IPromo
    {
        private struct Const
        {
            public static readonly int PromoPrice = 45;
            public static readonly int PromoQuantity = 2;
            public static readonly string PromoProductLabel = "B";
        }

        public void ProcessCart(List<CartItem> cartItems)
        {
            if (cartItems == null || cartItems.Count == 0)
                return;
            else
            {
                CartItem promoItem = cartItems.Where(x => x.Product.Label == Const.PromoProductLabel && !x.OfferApplied).FirstOrDefault();
                if (promoItem == null)
                    return;

                int promoQuantity = promoItem.Quantity / Const.PromoQuantity;
                int nonPromoQuantity = promoItem.Quantity % Const.PromoQuantity;
                int sellingPrice = (promoQuantity * Const.PromoPrice) + (nonPromoQuantity * promoItem.Product.UnitPrice);
                promoItem.OfferApplied = true;
                promoItem.SellingPrice = sellingPrice;
            }
        }
    }
}
