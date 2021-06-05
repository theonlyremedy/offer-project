using System.Collections.Generic;

namespace OfferConsole
{
    /// <summary>
    /// Interface for Promo
    /// </summary>
    public interface IPromo
    {
        /// <summary>
        /// Process Promo on CartItems
        /// </summary>
        void ProcessCart(List<CartItem> cartItems);
    }
}
