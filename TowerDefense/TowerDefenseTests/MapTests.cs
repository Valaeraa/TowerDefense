using TowerDefense;
using Xunit;

namespace TowerDefenseTests
{
    public class MapTests
    {
        private Map _map3 = new Map(3, 3);

        [Fact()]
        public void PointIsOnMap()
        {
            var target = _map3;
            Assert.True(target.OnMap(new Point(1, 2)));
        }

        [Fact()]
        public void PointIsNotOnMap()
        {
            var target = _map3;
            Assert.False(target.OnMap(new Point(3, 3)));
        }
    }
}