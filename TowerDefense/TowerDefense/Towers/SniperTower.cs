namespace TowerDefense.Towers
{
    public class SniperTower : Tower
    {
        protected override int Range => 2;
        protected override double Accuracy => 1.0;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}
