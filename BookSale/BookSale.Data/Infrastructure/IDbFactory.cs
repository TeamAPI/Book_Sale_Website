using System;

namespace BookSale.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BookSaleDbContext Init();
    }
}