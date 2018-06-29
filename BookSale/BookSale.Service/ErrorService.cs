using BookSale.Data.Infrastructure;
using BookSale.Data.Repository;
using BookSale.Model.Models;

namespace BookSale.Service
{
    public interface IErrorService
    {
        Error Create(Error errors);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error errors)
        {
            return _errorRepository.Add(errors);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}