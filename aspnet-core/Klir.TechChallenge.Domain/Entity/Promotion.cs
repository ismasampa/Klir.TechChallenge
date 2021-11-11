using Klir.TechChallenge.Domain.Entity.Interface;
using Klir.TechChallenge.Domain.Enum;
using System;

namespace Klir.TechChallenge.Domain.Entity
{
    public class Promotion : IPromotion
    {
        public string Description { get; set; }
        public PromotionType Type { get; set; }
        public short? Quantity { get; set; }
        public decimal? FinalValue { get; set; }

        public decimal Apply(int _Quantity, decimal Price)
        {
            decimal total = 0;
            if (this.Type == PromotionType.QuantityXPrice)
            {
                if(FinalValue==null)
                {
                    throw new Exception("Promotion 'Final Value' property is missing");
                }

                if (Quantity == null)
                {
                    throw new Exception("Promotion 'Quantity' property is missing");
                }
                
                int qttnormal = _Quantity % (int)Quantity;
                int qttpromotion = _Quantity / (int)Quantity;

                total = (qttnormal * Price) + (qttpromotion * (decimal)FinalValue);
            }


            return total;
        }

        public override string ToString() => Description;
    }
}
