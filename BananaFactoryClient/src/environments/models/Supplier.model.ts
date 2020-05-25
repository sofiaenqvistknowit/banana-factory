export class Supplier {
    public SupplierId: number;
    public Name: string;
    public OrgNr: string;
    public Address: string;
    public PhoneNumber: string;
    public Password: string;


    constructor(private supplier: Supplier) {
        this.createModel(supplier);
    }

    createModel(supplier: Supplier) {
        this.SupplierId = supplier.SupplierId;
        this.Name = supplier.Name;
        this.OrgNr = supplier.OrgNr;
        this.Address = supplier.Address;
        this.PhoneNumber = supplier.PhoneNumber;
        this.Password = supplier.Password;
    }

}