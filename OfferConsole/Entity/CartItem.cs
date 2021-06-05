namespace OfferConsole
{
    /// <summary>
    /// CartItem class, represents a LineItem in the Cart
    /// </summary>
    public class CartItem
    {
        #region Field
        private int quantity = 0;
        #endregion

        #region Prop
        /// <summary>
        /// Product
        /// </summary>
        public Product Product { get; private set; }

        /// <summary>
        /// Selling Price of the CartItem after appropriate Promo application
        /// </summary>
        public int SellingPrice { get; set; }

        /// <summary>
        /// Quantity of the Product
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                SellingPrice = quantity * Product.UnitPrice;
            }
        }
        #endregion

        #region Ctor
        public CartItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }
        #endregion
    }
}