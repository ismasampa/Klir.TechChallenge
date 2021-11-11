using Klir.TechChallenge.Domain.Entity;
using Klir.TechChallenge.Domain.Entity.Interface;
using System.Collections.Generic;

namespace Klir.TechChallenge.Infra.Data.DataMock
{
    public interface IDataMock
    {
        List<Product> Products { get; }
        List<Promotion> Promotions { get; }
        Cart Cart { get; }

    }
}