
namespace CommandPattern.Example1
{
    internal class AddCustomerCommand(CustomerService customerService) : ICommand
    {
        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}
