namespace FactoryMethodPattern.Example
{
    internal class ShartpViewController : Controller
    {
        protected override IViewEngine CreatViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
