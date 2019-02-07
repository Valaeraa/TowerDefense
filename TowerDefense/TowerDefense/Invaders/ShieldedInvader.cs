using System;

namespace TowerDefense.Invaders
{
    public class ShieldedInvader : Invader
    {
        public ShieldedInvader(Path path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if (Random.NextDouble() < 0.5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader but it sustained no damage.");
            }
        }
    }
}
