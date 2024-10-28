
namespace PrototypePattern
{
    internal class Circle : IComponenet
    {
        public int Redious { get; set; }
        public void Show()
        {
            Console.WriteLine("Showing circle with radious {0}", Redious);
        }

        public IComponenet Clone()
        {
            var clonedCirce = new Circle
            {
                Redious = Redious,
            };

            return clonedCirce;
        }
    }
}
