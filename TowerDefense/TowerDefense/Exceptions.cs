using System;

namespace TowerDefense
{
    public class TowerDefenceException : Exception
    {
        public TowerDefenceException()
        {

        }

        public TowerDefenceException(string message) : base(message)
        {

        }
    }

    public class OutOfBoundsException : TowerDefenceException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
