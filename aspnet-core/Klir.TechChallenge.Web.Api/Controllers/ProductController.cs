using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Entity.Interface;
using Klir.TechChallenge.Domain.Enum;
using Klir.TechChallenge.Domain.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        private readonly ICartRepository _cartrepository;

        public ProductController(IProductRepository repository, ICartRepository cartrepository)
        {
            _cartrepository = cartrepository;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.GetProducts();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _repository.GetProductById(id);
            if (product == null) return NoContent();
            return Ok(product);
        }

        [HttpGet("name={name}")]
        public IActionResult Get(string name)
        {
            var products = _repository.GetProductByName(name);
            if (products == null) return NoContent();
            return Ok(products);
        }

        [HttpPost("{id}/AddPromotion")]
        public IActionResult AddPromotion(int id, string promotionName)
        {
            if (id < 1) return BadRequest("Invalid product id");

            _repository.SetPromotionToProduct(id, promotionName);
            var product = _repository.GetProductById(id);
            var cart = _cartrepository.GetCart();
            var cartItem = cart.CartItems.Where(x => x.Product.Id == id).First();
            _cartrepository.UpdateItem(cartItem.Product, (short)cartItem.Quantity);
            return Ok(product);
        }

        [HttpDelete("{id}/RemovePromotion")]
        public IActionResult RemovePromotion(int id)
        {
            if (id < 1) return BadRequest("Invalid Id");
            var product = _repository.RemoveProductPromotion(id);
            var cart = _cartrepository.GetCart();           
            var cartitem = cart.CartItems.Where(x => x.Product.Id == id).First();
            _cartrepository.UpdateItem(cartitem.Product, (short)cartitem.Quantity);
            return Ok(product);
        }
    }
}