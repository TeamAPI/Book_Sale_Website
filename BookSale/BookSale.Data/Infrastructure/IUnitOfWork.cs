namespace BookSale.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}