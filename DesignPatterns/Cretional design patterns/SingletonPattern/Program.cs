namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configurationManager = ConfigurationManager.GetInstance();
            configurationManager.AddConfiguration("testKey", "testKey3131");

            var config = ConfigurationManager.GetInstance();

            Console.WriteLine("Key is {0}", config.GetConfiguration("testKey"));

            Console.ReadKey();
        }
    }
}
