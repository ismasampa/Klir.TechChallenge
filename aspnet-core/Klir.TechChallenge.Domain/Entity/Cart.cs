using Klir.TechChallenge.Domain.Entity.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Klir.TechChallenge.Domain.Entity
{
    public class Cart : ICart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public IList<CartItem> CartItems { get; private set; }
        public decimal Total;

        public Cart AddItem(Product product, short quantity)
        {
            this.CartItems.Remove( this.CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault() );
            this.CartItems.Add(new CartItem(product, quantity));

            return this;
        }

        public Cart UpdateItem(Product product, short quantity)
        {
            this.CartItems.Remove(this.CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault());
            this.CartItems.Add(new CartItem(product, quantity));

            return this;
        }
        public Cart RemoveItem(Product product)
        {
            this.CartItems.Remove(this.CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault());
            return this;
        }
    }
}
