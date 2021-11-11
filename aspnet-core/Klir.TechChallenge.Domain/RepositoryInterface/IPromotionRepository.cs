using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Entity.Interface;
using System.Collections.Generic;

namespace Klir.TechChallenge.Domain.Repository.Interface
{
    public interface IPromotionRepository
    {
        List<Promotion> GetAllPromotions();
    }
}