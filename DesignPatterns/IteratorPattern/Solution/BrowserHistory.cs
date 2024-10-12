
namespace IteratorPattern.Solution
{
    /// <summary>
    /// Now if you want to update storing Data structure from List to array then you just needs to
    /// create one new ArrayIterator, also by using this solutin you can traverse forward and backward
    /// with minimal changes in ListIterator
    /// </summary>
    internal class BrowserHistory
    {
        private List<string> _listOfUrls = [];

        public void Push(string url)
        {
            _listOfUrls.Add(url);
        }

        public string Pop()
        {
            int lastIndex = _listOfUrls.Count - 1;
            _listOfUrls.RemoveAt(lastIndex);
            return _listOfUrls[lastIndex];
        }

        public IIterator<string> GetIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator(BrowserHistory browserHistory) : IIterator<string>
        {
            private int currenctIndex;

            public string CurrectValue() => browserHistory._listOfUrls[currenctIndex];



            public bool HasNext() => currenctIndex < browserHistory._listOfUrls.Count;

            public void Next() => currenctIndex++;
        }
    }
}
