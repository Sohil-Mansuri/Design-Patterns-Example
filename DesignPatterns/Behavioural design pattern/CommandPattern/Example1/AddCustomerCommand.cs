
namespace CommandPattern.Example1
{
    internal class AddCustomerCommand(CustomerService customerService) : ICommand
    {
        public void Execute()
        {
            //delegating work 
            //here we can log also like this command is requested from this user 
            customerService.AddCustomer();
        }
    }
}
