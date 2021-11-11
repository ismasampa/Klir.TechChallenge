using Klir.TechChallenge.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Domain.Repository.Interface
{
    public interface ICartRepository
    {
        Cart GetCart();

        Cart AddItem(Product product, short quantity);

        Cart UpdateItem(Product product, short quantity);

        Cart RemoveItem(Product product);
    }
}