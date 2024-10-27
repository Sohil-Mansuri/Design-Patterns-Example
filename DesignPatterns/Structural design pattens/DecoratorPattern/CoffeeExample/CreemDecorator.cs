
namespace DecoratorPattern.CoffeeExample
{
    internal class CreemDecorator(ICoffee coffee) : ICoffee
    {
        private readonly decimal _amount = 10;
        public decimal Calculate()
        {
            return coffee.Calculate() + _amount;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + " with Creem";
        }
    }
}
