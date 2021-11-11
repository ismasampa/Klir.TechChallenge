using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Repository.Interface;
using System.Collections.Generic;

namespace Klir.TechChallenge.Infra.Data.Repository
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly DataMock.IDataMock _data;

        public PromotionRepository(DataMock.IDataMock data) => _data = data;

        public List<Promotion> GetAllPromotions()
        {
            return _data.Promotions;
        }
    }
}