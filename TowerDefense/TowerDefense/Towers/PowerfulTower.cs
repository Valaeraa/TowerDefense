namespace TowerDefense.Towers
{
    public class PowerfulTower : Tower
    {
        protected override int Power => 2;

        public PowerfulTower(MapLocation location) : base(location)
        {
        }
    }
}
