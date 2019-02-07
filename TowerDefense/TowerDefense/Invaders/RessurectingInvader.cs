namespace TowerDefense.Invaders
{
    public class RessurectingInvader : IInvader
    {
        private BasicInvader _incarnation1;
        private GuardianInvader _incarnation2;

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        public int Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;

        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        public RessurectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new GuardianInvader(path);
        }

        public void DecreaseHealth(int factor)
        {
            if (!_incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            else
            {
                _incarnation2.DecreaseHealth(factor);
            }
        }

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }
    }
}
