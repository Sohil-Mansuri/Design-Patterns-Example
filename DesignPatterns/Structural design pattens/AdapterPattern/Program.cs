namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView();

            imageView.AppyFilter(new VividFilter(), new Image());

            Console.ReadKey();
        }
    }
}
