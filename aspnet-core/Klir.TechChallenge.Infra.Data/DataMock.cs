using Klir.TechChallenge.Domain.Entity;
using System.Collections.Generic;

namespace Klir.TechChallenge.Infra.Data.DataMock
{
    public class DataMock : IDataMock
    {
        public DataMock()
        {
            Promotions = new List<Promotion>()
            {
                new Promotion( ){ Description = "Buy1Get1Free",
                 FinalValue = 20,
                 Quantity = 2,
                 Type = Domain.Enum.PromotionType.QuantityXPrice
                },
                new Promotion( ){ Description = "Get3For10Euros",
                 FinalValue = 10,
                 Quantity = 3,
                 Type = Domain.Enum.PromotionType.QuantityXPrice
                }
            };

            var prodpromon1 = new Product(1, "Product A", 20);
            prodpromon1.SetPromotion(new Promotion()
            {
                Description = "Buy1Get1Free",
                FinalValue = 20,
                Quantity = 2,
                Type = Domain.Enum.PromotionType.QuantityXPrice
            });
            var prodpromon2 = new Product(2, "Product B", 4);
            prodpromon2.SetPromotion(new Promotion()
            {
                Description = "Get3For10Euros",
                FinalValue = 10,
                Quantity = 3,
                Type = Domain.Enum.PromotionType.QuantityXPrice
            });

            Products = new List<Product>()
            {
                prodpromon1,
                prodpromon2,
                new Product(3, "Product C", 2),
                new Product(4, "Product D", 4)
            };

            Cart = new Cart();
        }

        public List<Product> Products { get; private set; }

        public List<Promotion> Promotions { get; private set; }

        public Cart Cart { get; private set; }
    }
}