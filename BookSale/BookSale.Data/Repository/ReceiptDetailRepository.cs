using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IReceiptDetailRepository : IRepository<ReceiptDetail>
    {
    }
    public class ReceiptDetailRepository : RepositoryBase<ReceiptDetail>, IReceiptDetailRepository
    {
        public ReceiptDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
