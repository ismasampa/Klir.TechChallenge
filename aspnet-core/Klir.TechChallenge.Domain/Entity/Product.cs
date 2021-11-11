using Klir.TechChallenge.Domain.Entity.Interface;

namespace Klir.TechChallenge.Domain.Entity
{
    public class Product : IProduct
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(int id, string name, decimal price) : this(name, price)
        {
            Id = id;
        }

        internal Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product SetPrice(decimal newPrice)
        {
            Price = newPrice;
            return this;
        }

        public IPromotion CurrentPromotion { get; private set; }

        public Product SetPromotion(IPromotion promotion)
        {
            CurrentPromotion = promotion;
            return this;
        }

        public Product RemovePromotion(IPromotion promotion)
        {
            if (CurrentPromotion == promotion)
            {
                CurrentPromotion = null;
            }

            return this;
        }


    }
}
