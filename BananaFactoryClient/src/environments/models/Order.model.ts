export class Order {
    public OrderId: number;
    public CustomerNumber: number;
    public Date: Date;
    public Status: string;
    public PaymentType: string;
    public DeliveryType: string;
    

    constructor(private order: Order) {
        this.createModel(order);
    }

    createModel(order: Order) {
        this.OrderId = order.OrderId;
        this.CustomerNumber = order.CustomerNumber;
        this.Date = order.Date;
        this.Status = order.Status;
        this.PaymentType = order.PaymentType;
        this.DeliveryType = order.DeliveryType;
    }

}