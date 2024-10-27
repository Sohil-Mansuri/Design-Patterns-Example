
namespace FlyweightPattern.Solution
{
    internal class PointInfo(int x, int y, PointIcon pointIcon)
    {
        public int X { get; init; } = x;

        public int Y { get; init; } = y;

        public PointIcon PointIcon { get; init; } = pointIcon;


        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2}) cordinates", PointIcon.PointType, X, Y);
        }
    }
}
