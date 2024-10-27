
namespace ProxyPattern.Solution
{
    internal class EbookProxy(string title) : IEbook
    {
        private RealEbook realEbook;

        public string GetFileName()
        {
            return title;
        }

        //Laxy loading create real object only when it is needed
        //Postpon the creating the real object
        public void Show()
        {
            realEbook ??= new RealEbook(title);
            realEbook.Show();
        }
    }
}
