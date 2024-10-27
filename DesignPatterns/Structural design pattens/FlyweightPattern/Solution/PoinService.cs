
namespace FlyweightPattern.Solution
{
    internal class PoinService(PointIconFactory pointIconFactory)
    {
        public List<PointInfo> GetPoints()
        {
            return
            [
                new PointInfo(3,5, pointIconFactory.GetPointIcon(PointType.Resturant)),
                new PointInfo(6,8, pointIconFactory.GetPointIcon(PointType.Shop)),
                new PointInfo(5,6, pointIconFactory.GetPointIcon(PointType.Resturant)),
                new PointInfo(4,7, pointIconFactory.GetPointIcon(PointType.Resturant)),
                new PointInfo(9,7, pointIconFactory.GetPointIcon(PointType.Resturant))
            ];
        }
    }
}
