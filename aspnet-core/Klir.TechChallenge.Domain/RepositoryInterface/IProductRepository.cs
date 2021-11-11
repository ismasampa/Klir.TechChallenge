using Klir.TechChallenge.Domain.Entity.Interface;
using System.Collections.Generic;

namespace Klir.TechChallenge.Domain.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Entity.Product> GetProducts();

        Entity.Product GetProductById(int id);

        IEnumerable<Entity.Product> GetProductByName(string name);

        Entity.Product SetPromotionToProduct(int productId, IPromotion promotion);

        Entity.Product RemoveProductPromotion(int productId);
    }
}