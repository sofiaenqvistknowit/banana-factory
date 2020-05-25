using System;

namespace BananaFactory.Model.DTO
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
    }
}