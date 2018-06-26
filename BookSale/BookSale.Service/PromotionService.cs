using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System.Collections.Generic;
using System;

namespace BookSale.Service
{
    public interface IPromotionService
    {
        void Add(Promotion promotion);

        void Update(Promotion promotion);

        void Delete(int id);

        IEnumerable<Promotion> GetAll();
        IEnumerable<Promotion> GetAllPaging(int page, int pagesize, out int totalrow);
        void Savechange();
    }

    public class PromotionService : IPromotionService
    {
        private IPromotionRepository _promotionRepository;
        private IUnitOfWork _unitOfWork;
        public PromotionService(IPromotionRepository promotionRepository, IUnitOfWork unitOfWrok)
        {
            this._promotionRepository = promotionRepository;
            this._unitOfWork = unitOfWrok;

        }

        public void Add(Promotion promotion)
        {
            _promotionRepository.Add(promotion);
        }

        public void Delete(int id)
        {
            _promotionRepository.Delete(id);
        }

        public IEnumerable<Promotion> GetAll()
        {
            return _promotionRepository.GetAll();
        }

        public IEnumerable<Promotion> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            throw new NotImplementedException();
        }

        public void Savechange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Promotion promotion)
        {
            _promotionRepository.Update(promotion);
        }
    }
}