using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _repository;
        private readonly IProductRepository _productRepository;

        public CartController(ICartRepository repository, IProductRepository productRepository)
        {
            _repository = repository;
            _productRepository = productRepository;
        }

        [HttpGet]
        public Cart Get()
        {
            return _repository.GetCart();
        }

        [HttpPost("{productId}/setquantity/{quantity}")]
        public IActionResult AddItem(int productId, short quantity)
        {
            if (productId < 0) return BadRequest("Invalid Product Id");
            if (quantity < 0) return BadRequest("Invalid Quantity");

            var product = _productRepository.GetProductById(productId);

            if (product == null) return BadRequest($"There's no Product with Id {productId}");

            if (_repository.GetCart().CartItems.Any(p => p.Product.Id == productId) == false)
            {
                return Ok(_repository.AddItem(product, quantity));
            }
            return Ok(_repository.UpdateItem(product, quantity));
        }

        [HttpDelete("{productId}")]
        public IActionResult RemoveItem(int productId)
        {
            if (productId < 0) return BadRequest("Invalid Product Id");

            var product = _productRepository.GetProductById(productId);

            if (product == null) return BadRequest($"There's no Product with Id {productId}");

            if (_repository.GetCart().CartItems.Any(p => p.Product.Id == productId) == false) return Ok(_repository.GetCart());

            return Ok(_repository.RemoveItem(product));
        }
    }
}