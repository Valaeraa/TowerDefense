namespace TowerDefense.Invaders
{
    public class FastInvader : Invader
    {
        protected override int StepSize => 2;

        public FastInvader(Path path) : base(path)
        {
        }
    }
}
