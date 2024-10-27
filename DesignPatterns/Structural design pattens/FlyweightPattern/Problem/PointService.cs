
namespace FlyweightPattern.Problem
{
    internal class PointService
    {
        public List<PointInfo> GetPoints()
        {
            return
            [
                new PointInfo(2,4,PointType.Cafe, null),
                new PointInfo(4,5,PointType.Home, null),
            ];
        }
    }
}
