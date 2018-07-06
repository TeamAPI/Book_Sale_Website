using BookSale.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? created_date { set; get; }
        public int? created_by { set; get; }

        public DateTime? updated_date { set; get; }
        public int? updated_by { set; get; }
    }
}