export class Product {
    public ProductId: number;
    public ImageId: number;
    public SupplierId: number;
    public ProductTypeId: number;
    public Name: string;
    public Color: string;
    public Size: string;
    public Weight: string;
    public Price: string;


   

    constructor(ProductId,ImageId ,SupplierId,ProductTypeId,Name,Color,Size,Weight,Price) {
        this.ProductId = ProductId;
        this.ImageId = ImageId;
        this.SupplierId = SupplierId;
        this.ProductTypeId = ProductTypeId;
        this.Name = Name;
        this.Color = Color;
        this.Size = Size;
        this.Weight = Weight;
        this.Price = Price;
    }

}