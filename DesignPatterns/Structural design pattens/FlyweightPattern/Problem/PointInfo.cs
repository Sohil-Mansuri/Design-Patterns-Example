
using FlyweightPattern.Solution;

namespace FlyweightPattern.Problem
{
    /// <summary>
    /// This object is huge, suppose we have 10 points as home so it will store 10 home icon bytes 
    /// which will consume lots fo memory 
    /// </summary>
    internal class PointInfo(int x, int y, PointType pointType, byte[]? icon)
    {
        public int X { get; init; } = x;
        public int Y { get; init; } = y;
        public PointType PointType { get; init; } = pointType;
        public byte[]? Icon { get; init; } = icon;

        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2}) cordinates", PointType, X, Y);
        }
    }
}
