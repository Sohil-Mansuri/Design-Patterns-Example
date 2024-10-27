
namespace ProxyPattern.Solution
{
    internal class RealEbook : IEbook
    {
        private readonly string _title;

        public RealEbook(string title)
        {
            _title = title;
            Load();
        }

        public string GetFileName()
        {
            return _title;
        }

        public void Load()
        {
            Console.WriteLine("Loading file {0}", _title);
        }


        public void Show()
        {
            Console.WriteLine("Showing file {0}", _title);
        }
    }
}
