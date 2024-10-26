
namespace CompositePattern.Solution
{
    internal class Shape : IComponant
    {
        private readonly string _value;

        public Shape(string value)
        {
            _value = value;
        }
        public void Render()
        {
            Console.WriteLine("Shape {0}", _value);
        }
    }
}
