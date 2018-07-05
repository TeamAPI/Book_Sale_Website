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
    public interface IOrderService
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(int id);

        void Save();
    }
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IUnitOfWork _unitOfwork;
        private IOrderDetailsRepository _orderDetailRepository;
        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfwork, IOrderDetailsRepository orderDetailRepository)
        {
            this._orderDetailRepository = orderDetailRepository;
            this._orderRepository = orderRepository;
            this._unitOfwork = unitOfwork;

        }

        public void Save()
        {
            _unitOfwork.Commit();
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}
