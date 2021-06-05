using System.Collections.Generic;

namespace OfferConsole
{
    /// <summary>
    /// Promo Engine that applies Promo Offers on the Cart Items
    /// </summary>
    public class PromoEngine
    {
        #region Field
        /// <summary>
        /// Dummy List of Promos
        /// </summary>
        List<IPromo> promoList = null;
        #endregion

        #region Ctor
        public PromoEngine()
        {
            promoList = new List<IPromo>()
            {
               new ProductAPromo(),
               new ProductBPromo(),
               new ProductCDPromo()
            };
        }
        #endregion

        #region Method
        /// <summary>
        /// Applies Promo on specified CartItem List
        /// </summary>
        internal void ApplyPromo(List<CartItem> cartItems)
        {
            foreach(IPromo promo in promoList)
            {
                promo.ProcessCart(cartItems);
            }
        }
        #endregion
    }
}
