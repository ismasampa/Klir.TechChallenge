using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Entity.Interface;
using Klir.TechChallenge.Domain.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Klir.TechChallenge.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataMock.IDataMock _data;

        public ProductRepository(DataMock.IDataMock data) => _data = data;

        public Product SetPromotionToProduct(int productId, string promotionName)
        {
            var product = GetProductById(productId);
            var promotion = GetPromotionByName(promotionName);
            product.SetPromotion(promotion);

            return product;
        }

        public Product GetProductById(int id)
        {
            return _data.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProductByName(string name)
        {
            return _data.Products.Where(p => p.Name == name).FirstOrDefault();
        }
        public Promotion GetPromotionByName(string name)
        {
            return _data.Promotions.Where(p => p.Description == name).FirstOrDefault();
        }

        public IEnumerable<Promotion> GetPromotions()
        {
            return _data.Promotions.ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _data.Products;
        }

        public Product RemoveProductPromotion(int productId)
        {
            var product = GetProductById(productId);
            product.RemovePromotion(product.CurrentPromotion);
            return product;
        }
    }
}