using Klir.TechChallenge.Domain.Enum;

namespace Klir.TechChallenge.Domain.Entity.Interface
{
    public interface IPromotion
    {
        string Description { get; set; }
        decimal? FinalValue { get; set; }
        short? Quantity { get; set; }
        PromotionType Type { get; set; }

        decimal Apply(int Quantity, decimal Price);
        string ToString();
    }
}