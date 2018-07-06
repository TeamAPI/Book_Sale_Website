using System;

namespace BookSale.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? created_date { set; get; }
        int? created_by { set; get; }
        DateTime? updated_date { set; get; }
        int? updated_by { set; get; }
    }
}