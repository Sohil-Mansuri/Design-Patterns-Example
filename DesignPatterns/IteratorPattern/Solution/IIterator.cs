
namespace IteratorPattern.Solution
{
    internal interface IIterator<T>
    {
        bool HasNext();
        T CurrectValue();
        void Next();
    }
}
