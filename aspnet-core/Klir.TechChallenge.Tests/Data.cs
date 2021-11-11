using Xunit;
using Klir.TechChallenge.Domain.Entity;
using System.Collections.Generic;
using Klir.TechChallenge.Infra.Data.DataMock;
using System.Linq;

namespace Klir.TechChallenge.Tests
{
    public class ModelValidation
    {

        [Fact(DisplayName = "Promotion")]
        [Trait("Models", "Promotion")]
        public void Promotion()
        {
            
            DataMock data = new DataMock();
            var promo = data.Promotions.ToList();
            Assert.True( promo.Count > 0);
        }


        [Fact(DisplayName = "Product")]
        [Trait("Models", "Product")]
        public void Product()
        {
            DataMock data = new DataMock();
            var products = data.Products.ToList();
            Assert.True(products.Count > 0);
        }


        [Fact(DisplayName = "Cart")]
        [Trait("Models", "Cart")]
        public void Cart()
        {

            DataMock data = new DataMock();
            List<CartItem> testitems = new List<CartItem>();

            data.Cart.AddItem(data.Products.ElementAt(0), 5);
            data.Cart.AddItem(data.Products.ElementAt(1), 3);
            data.Cart.AddItem(data.Products.ElementAt(2), 4);

            Assert.NotNull(data.Cart);
            Assert.Equal(60, data.Cart.CartItems[0].Total); // 5 products of 20 EU with 2 for 20 EU promotion  ( 60 EU )
            Assert.Equal(10, data.Cart.CartItems[1].Total); // 3 products of 4 EU with 3 for 10 EU promotion  ( 10 EU )
            Assert.Equal(8, data.Cart.CartItems[2].Total); // 4 products of 2 EU without promotion ( 8 EU )
        }

    }
}
