
namespace IteratorPattern.Problem
{
    /// <summary>
    /// This is fine implementation, but tomorrow if you change some data structure to store data from List to Stack or Array
    /// then you have to made changes for all its references where you have used BrowserHistory class 
    /// also it is not follwoing OCP 
    /// check its solution
    /// </summary>
    internal class BrowserHistory
    {
        private List<string> _urlHistory = new();

        public void Push(string url)
        {
            _urlHistory.Add(url);
        }

        public string Pop()
        {
            var lastIndex = _urlHistory.Count - 1;
            _urlHistory.RemoveAt(lastIndex);
            return _urlHistory[lastIndex];
        }

        public List<string> GetUrls()
        {
            return _urlHistory;
        }
    }
}
