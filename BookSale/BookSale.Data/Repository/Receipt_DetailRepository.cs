using BookSale.Data.Infrastructure;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Data.Repositories
{
    public interface IReceipt_DetailRepository : IRepository<Receipt_Detail>
    {
    }
    public class Receipt_DetailRepository : RepositoryBase<Receipt_Detail>, IReceipt_DetailRepository
    {
        public Receipt_DetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
