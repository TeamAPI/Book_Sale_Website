using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Service
{
    public class SupplyhouseService
    {
        private ISupplyhouseRepository _supplyhouseReporitory;
        private IUnitOfWork _unitOfWork;
        public SupplyhouseService(ISupplyhouseRepository supplyhouseReporitory, IUnitOfWork unitOfWork)
        {
            this._supplyhouseReporitory = supplyhouseReporitory;
            this._unitOfWork = unitOfWork;
        }
        public Supplyhouse GetById(int id)
        {
            return _supplyhouseReporitory.GetSingleById(id);
        }

    }
}
