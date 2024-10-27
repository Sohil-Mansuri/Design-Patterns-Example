
namespace DecoratorPattern.CoffeeExample
{
    internal class CoffeeDecorater : ICoffee
    {
        public decimal Calculate()
        {
            return 20;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
