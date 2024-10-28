using FactoryMethodPattern.Example;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new ProductController();
            product.GetProducts();

            var customer = new CustomerController();
            customer.GetCustomers();

            Console.ReadKey();
        }
    }
}
