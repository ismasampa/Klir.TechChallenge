namespace Klir.TechChallenge.Domain.Entity.Interface
{
    public interface ICartItem
    {
        decimal Price { get; }
        Product Product { get; }
        int Quantity { get; }
        decimal Total { get; }
    }
}