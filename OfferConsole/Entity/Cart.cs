using System.Collections.Generic;
using System.Linq;

namespace OfferConsole
{
    public class Cart
    {
        #region Field
        private PromoEngine promoEngine;
        #endregion

        #region Prop
        /// <summary>
        /// Returns True if Cart is empty
        /// </summary>
        public bool IsEmpty { get; private set; }

        /// <summary>
        /// List of Items in the Cart
        /// </summary>
        public List<CartItem> CartItems { get; private set; }

        /// <summary>
        /// Cart Value after all Promotion Applied
        /// </summary>
        public int CartValue {
            get {
                promoEngine.ApplyPromo(CartItems);
                return CartItems.Sum(x => x.SellingPrice);
            }
        }
        #endregion

        #region Ctor
        /// <summary>
        /// Contructor takes in PromoEngine instance, (Note: ideally should've been Interface)
        /// </summary>
        public Cart(PromoEngine promoEngine)
        {
            CartItems = new List<CartItem>();
            this.promoEngine = promoEngine;
        }
        #endregion

        #region Method
        /// <summary>
        /// Adds the specified Product into the Cart
        /// </summary>
        public void AddItem(Product product)
        {
            CartItem cartItem = CartItems.FirstOrDefault(x => x.Product.Label == product.Label);
            if (cartItem == null)
            {
                cartItem = new CartItem(product);
                CartItems.Add(cartItem);
            }
            else
                cartItem.Quantity++;
        }
        #endregion
    }
}