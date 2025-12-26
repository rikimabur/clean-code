namespace SOLID;
//DIP violation
//public class CustomerRepository
//{
//    public void Add(string customerName)
//    {
//        // Implementation details for adding customer
//    }
//}

//public class CustomerService
//{
//    private readonly CustomerRepository _customerRepository = new CustomerRepository();
//    public void RegisterCustomer(string customerName)
//    {
//        _customerRepository.Add(customerName);
//        // Additional high-level operations
//    }
//}
//DIP-Adhering refactoring
public interface ICustomerRepository
{
    void Add(string customerName);
}
public class CustomerRepository : ICustomerRepository
{
    public void Add(string customerName)
    {
        // Implementation details for adding customer
    }
}

public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public void RegisterCustomer(string customerName)
    {
        _customerRepository.Add(customerName);
        // Additional high-level operations
    }
}