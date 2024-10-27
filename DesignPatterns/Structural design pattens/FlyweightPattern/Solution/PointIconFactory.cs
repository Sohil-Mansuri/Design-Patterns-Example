
namespace FlyweightPattern.Solution
{
    internal class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _pointIcons = [];

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!_pointIcons.ContainsKey(pointType))
            {
                //create new icon
                var pointIcon = new PointIcon(pointType, null);
                _pointIcons.Add(pointType, pointIcon);
            }

            return _pointIcons[pointType];
        }
    }
}
