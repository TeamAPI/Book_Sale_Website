using BookSale.Data;
using System;

namespace BookSale.Data.Infrastructure
{
    public interface IDBFactory : IDisposable
    {
        BookSaleDBContext init();
    }
}