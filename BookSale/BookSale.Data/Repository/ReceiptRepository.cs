using BookSale.Data.Infrastructure;
using BookSale.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IReceiptRepository : IRepository<Receipt>
    {
    }
    public class ReceiptRepository : RepositoryBase<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
