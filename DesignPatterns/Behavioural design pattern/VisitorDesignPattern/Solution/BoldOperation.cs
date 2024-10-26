
namespace VisitorDesignPattern.Solution
{
    internal class BoldOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Bold heading");
        }

        public void Apply(AncharNode node)
        {
            Console.WriteLine("Bold anchor tag text");
        }
    }
}
