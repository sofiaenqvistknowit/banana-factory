using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BananaFactory.Business.Interfaces;
using BananaFactory.Business.Mapping;
using BananaFactory.Model;
using BananaFactory.Model.DTO;
using BananaFactory.Repository;
using BananaFactory.Repository.Repositories;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BananaFactory.Business
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(OrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public List<OrderDto> GetAll()
        {

            var orders = new List<Order>();
            orders.Add(new Order
            {

            });
            orders.Add(new Order
            {

            });

            var ordersDTO = new List<OrderDto>();
            foreach (var order in orders)
            {
                ordersDTO.Add(OrderMapper.ModelToDto(order));
            }
            return ordersDTO;
            //return_orderRepository.GetAll().ToList();
        }

        public OrderDto GetById(int id)
        {
            return OrderMapper.ModelToDto(_orderRepository.GetById(id));
        }

        List<OrderDto> IOrderService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
