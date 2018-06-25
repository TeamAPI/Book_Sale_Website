namespace BookSale.Data.Infrastructure
{
    public class DBFactory : Disposable, IDBFactory
    {
        private BookSaleDBContext dbContext;

        public BookSaleDBContext Init()
        {
            return dbContext ?? (dbContext = new BookSaleDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}