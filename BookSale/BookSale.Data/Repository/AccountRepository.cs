using BookSale.Data.Infrastructure;
using BookSale.Models.Models;

namespace BookSale.Data.Repository
{
    public interface IAccountRepository
    {
        // Viết phương thức thêm nếu chưa có sẳng

    }
    public class AccountRepository : RepositoryBase<Account> , IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    //
    //Triển khai phương thức trên iterface
}