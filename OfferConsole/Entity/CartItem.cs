namespace OfferConsole
{
    public class CartItem
    {
        #region Field
        private int quantity = 0;
        #endregion

        #region Prop
        public Product Product { get; private set; }
        public bool OfferApplied { get; set; }
        public int SellingPrice { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                SellingPrice = quantity * Product.UnitPrice;
                OfferApplied = false;
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