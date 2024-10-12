namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Problem section");

            var imageStorage = new Problem.ImageStorage(Problem.ImageType.Png, Constancs.BlackAndWhite);
            imageStorage.Save("test.png");

            Console.WriteLine("Output from Solution section");

            var newImageStorage = new Solution.ImageStorage();
            newImageStorage.Save("test1.jpg", new Solution.JpgCompressor(), new Solution.BlackAndWhiteFilter());
            newImageStorage.Save("test2.png", new Solution.PngCompressor(), new Solution.BlackAndWhiteFilter());


            Console.ReadKey();
        }
    }
}
