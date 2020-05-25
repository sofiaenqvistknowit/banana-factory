export class Customer {
    public CustomerNumber: number;
    public Surname: string;
    public Lastname: string;
    public Address: string;
    public PhoneNumber: string;
    public ZipCode: string;
    public City: string;
    public Mail: string;
    public Password: string;


    constructor(private customer: Customer) {
        this.createModel(customer);
    }

    createModel(customer: Customer) {
        this.CustomerNumber = customer.CustomerNumber;
        this.Surname = customer.Surname;
        this.Lastname = customer.Lastname;
        this.Address = customer.Address;
        this.PhoneNumber = customer.PhoneNumber;
        this.ZipCode = customer.ZipCode;
        this.City = customer.City;
        this.Mail = customer.Mail;
        this.Password = customer.Password;
    }

}