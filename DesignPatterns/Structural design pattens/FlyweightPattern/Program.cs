namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Prblem section");

            var pointServie = new Problem.PointService();

            foreach (var point in pointServie.GetPoints())
            {
                point.Draw();
            }


            Console.WriteLine("Output from solution section");

            var newPointService = new Solution.PoinService(new Solution.PointIconFactory());

            foreach (var point in newPointService.GetPoints())
            {
                point.Draw();
            }

            Console.ReadKey();
        }
    }
}
