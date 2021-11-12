
using Klir.TechChallenge.Domain.Entity.Interface;
using Klir.TechChallenge.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionRepository _repository;

        public PromotionController(IPromotionRepository repository) => _repository = repository;

        [HttpGet]
        public IEnumerable<IPromotion> Get()
        {
            return _repository.GetAllPromotions();
        }
    }
}