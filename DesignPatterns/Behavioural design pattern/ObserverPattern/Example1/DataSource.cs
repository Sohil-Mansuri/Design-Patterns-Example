
namespace ObserverPattern.Example1
{
    internal class DataSource(IObservable observable)
    {
        private string? _value;
        public string? Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                observable.Notfify();
            }
        }
    }
}
