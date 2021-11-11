using System.Collections.Generic;

namespace Klir.TechChallenge.Domain.Entity.Interface
{
    public interface ICart
    {
        IList<CartItem> CartItems { get; }

        Cart AddItem(Product product, short quantity);
        Cart RemoveItem(Product product);
        Cart UpdateItem(Product product, short quantity);
    }
}