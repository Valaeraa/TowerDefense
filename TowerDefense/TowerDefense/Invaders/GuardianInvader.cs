namespace TowerDefense.Invaders
{
    public class GuardianInvader : Invader
    {
        public override int Health => 3;

        public GuardianInvader(Path path) : base(path)
        {
        }
    }
}
