
namespace ObserverPattern.Example1
{
    internal class ChartObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("data updated in Chart");
        }
    }
}
