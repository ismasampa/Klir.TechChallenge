
using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Repository.Interface;
using Klir.TechChallenge.Infra.Data.DataMock;

namespace Klir.TechChallenge.Infra.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly IDataMock _data;

        public CartRepository(IDataMock data) => _data = data;
        public Cart AddItem(Product product, short quantity)
        {
            return _data.Cart.AddItem(product, quantity);
        }

        public Cart UpdateItem(Product product, short quantity)
        {
            return _data.Cart.UpdateItem(product, quantity);
        }

        public Cart GetCart()
        {
            return _data.Cart;
        }

        public Cart RemoveItem(Product product)
        {
            return _data.Cart.RemoveItem(product);
        }
    }
}