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

        public Product SetPromotionToProduct(int productId, IPromotion promotion)
        {
            var product = GetProductById(productId);
            product.SetPromotion(promotion);
            return product;
        }

        public Product GetProductById(int id)
        {
            return _data.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            return _data.Products.Where(p => p.Name == name).ToList();
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