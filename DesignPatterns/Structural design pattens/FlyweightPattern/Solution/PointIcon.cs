
namespace FlyweightPattern.Solution
{
    internal class PointIcon(PointType pointType, byte[]? icon)
    {
        public PointType PointType { get; init; } = pointType;

        public byte[]? Icon { get; init; } = icon;
    }
}
