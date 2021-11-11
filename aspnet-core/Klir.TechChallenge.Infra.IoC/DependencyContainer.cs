using Klir.TechChallenge.Domain.Repository.Interface;
using Klir.TechChallenge.Infra.Data.DataMock;
using Klir.TechChallenge.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Klir.TechChallenge.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IDataMock, DataMock>();
            services.AddSingleton<IPromotionRepository, PromotionRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ICartRepository, CartRepository>();
        }
    }
}