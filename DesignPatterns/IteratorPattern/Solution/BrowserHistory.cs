
namespace IteratorPattern.Solution
{
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

            public string CurrectValue()
            {
                return browserHistory._listOfUrls[currenctIndex];
            }

            public bool HasNext()
            {
                return currenctIndex < browserHistory._listOfUrls.Count;
            }

            public void Next()
            {
                currenctIndex++;
            }
        }
    }
}
