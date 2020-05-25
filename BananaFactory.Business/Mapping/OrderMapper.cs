using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaFactory.Model.DTO;
using BananaFactory.Model;


namespace BananaFactory.Business.Mapping
{
    public static class OrderMapper
    {
        public static OrderDto ModelToDto(Order model)
        {
            return new OrderDto
            {
                OrderID = model.OrderID,
                Customer = model.Customer,
                DeliveryStatus = model.DeliveryStatus,
                DeliveryType = model.DeliveryType,
                OrderDate = model.OrderDate,
                OrderStatus = model.OrderStatus,
                PaymentStatus = model.PaymentStatus,
                PaymentType = model.PaymentType,
                CustomerID = model.CustomerID
            };

        }
    }
}
