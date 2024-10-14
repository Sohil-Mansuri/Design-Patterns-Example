using ObserverPattern.Example1;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Example 1");

            IObservable dataSourceObservasable = new DataSourceObservable();
            dataSourceObservasable.Attach(new ChartObserver());
            dataSourceObservasable.Attach(new SpreadSheetObserver());
            var dataSource = new DataSource(dataSourceObservasable);
            dataSource.Value = "sohil";

            Console.ReadKey();
        }
    }
}
