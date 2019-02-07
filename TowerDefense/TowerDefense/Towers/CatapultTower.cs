using System;

namespace TowerDefense.Towers
{
    public class CatapultTower : Tower
    {
        protected override int Range => 3;
        protected override double Accuracy => 0.5;

        public CatapultTower(MapLocation location) : base(location)
        {
        }
    }
}
