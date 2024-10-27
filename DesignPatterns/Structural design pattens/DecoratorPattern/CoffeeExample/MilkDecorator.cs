
namespace DecoratorPattern.CoffeeExample
{
    internal class MilkDecorator(ICoffee coffee) : ICoffee
    {
        private readonly decimal _amount = 5;
        public decimal Calculate()
        {
            return coffee.Calculate() + 5;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + " with Milk";
        }
    }
}
