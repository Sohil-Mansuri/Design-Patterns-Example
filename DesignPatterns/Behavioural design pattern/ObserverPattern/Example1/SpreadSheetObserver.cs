
namespace ObserverPattern.Example1
{
    internal class SpreadSheetObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("data updated in SpreadSheet");
        }
    }
}
