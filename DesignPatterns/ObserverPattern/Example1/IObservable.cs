
namespace ObserverPattern.Example1
{
    internal interface IObservable
    {
        void Attach(IObserver observer);

        void Dettach(IObserver observer);

        void Notfify();
    }
}
