

namespace ObserverPattern.Example1
{
    internal class DataSourceObservable : IObservable
    {
        private List<IObserver> observers = []; 
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notfify()
        {
            if(observers.Count > 0)
            {
                foreach(IObserver observer in observers)
                {
                    observer.Update();
                }
            }
        }
    }
}
