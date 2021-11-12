using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Entity.Interface;
using System.Collections.Generic;

namespace Klir.TechChallenge.Domain.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int id);

        Product GetProductByName(string name);
        
        Promotion GetPromotionByName(string name);



        Product SetPromotionToProduct(int productId, string promotionName);

        Product RemoveProductPromotion(int productId);
        IEnumerable<Promotion> GetPromotions();
    }
}