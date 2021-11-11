using Klir.TechChallenge.Domain.Entity.Interface;

namespace Klir.TechChallenge.Domain.Entity
{
    public class CartItem : ICartItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price => Product.Price;
        public decimal Total { get; private set; }


        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Total = product.Price * quantity;
            if (product.CurrentPromotion != null)
                {
                    Total = product.CurrentPromotion.Apply(quantity, Price);
                }
        }
    }
}
