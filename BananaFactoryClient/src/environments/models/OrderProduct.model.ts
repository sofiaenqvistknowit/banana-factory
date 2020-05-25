export class OrderProduct {
    public OrderProductId: number;
    public OrderId: number;
    public ProductId: number;
    public Quality: string;
    

    constructor(private orderProduct: OrderProduct) {
        this.createModel(orderProduct);
    }

    createModel(orderProduct: OrderProduct) {
        this.OrderProductId = orderProduct.OrderProductId;
        this.OrderId = orderProduct.OrderId;
        this.ProductId = orderProduct.ProductId;
        this.Quality = orderProduct.Quality;
    }

}