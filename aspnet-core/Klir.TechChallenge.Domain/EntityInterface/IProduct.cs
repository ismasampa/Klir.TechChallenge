namespace Klir.TechChallenge.Domain.Entity.Interface

{
    public interface IProduct
    {
        IPromotion CurrentPromotion { get; }
        int Id { get; }
        string Name { get; }
        decimal Price { get; }

        Product SetPrice(decimal newPrice);
        Product RemovePromotion(IPromotion promotion);
        Product SetPromotion(IPromotion promotion);
    }
}