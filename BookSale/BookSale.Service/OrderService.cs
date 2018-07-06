using BookSale.Data.Infrastructure;
using BookSale.Data.Repositories;
using BookSale.Model.Models;
using System;
using System.Collections.Generic;

namespace BookSale.Service
{
    public interface IOrderService
    {
        Order Create(ref Order order, List<OrderDetail> orderDetails);

        void UpdateStatus(int orderId, string tt);

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

        public Order Create(ref Order order, List<OrderDetail> orderDetails)
        {
            try
            {
                _orderRepository.Add(order);
                _unitOfwork.Commit();

                foreach (var orderDetail in orderDetails)
                {
                    orderDetail.OrderID = order.OrderID;
                    _orderDetailRepository.Add(orderDetail);
                }
                return order;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateStatus(int orderId, string tt)
        {
            var order = _orderRepository.GetSingleById(orderId);
            order.OrderStatus = tt;
            _orderRepository.Update(order);
        }
    }
}