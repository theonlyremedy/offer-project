namespace OfferConsole
{
    public class CartItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; set; }
        public bool OfferApplied { get; set; }
        public int SellingPrice { get; set; }

        public CartItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }
    }
}