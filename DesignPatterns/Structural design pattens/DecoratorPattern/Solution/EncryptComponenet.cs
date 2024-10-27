
namespace DecoratorPattern.Solution
{
    /// <summary>
    /// Decorator
    /// </summary>
    /// <param name="component"></param>
    internal class EncryptComponenet(IComponent component) : IComponent
    {
        public void Operation(string data)
        {
            var enryptData = "384938439438fdfjdkj48943";
             component.Operation(enryptData);
        }
    }
}
