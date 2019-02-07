using TowerDefense.Invaders;

namespace TowerDefense.Towers
{
    public interface ITower
    {
        void FireOnInvaders(IInvader[] invaders);
        bool IsSuccessfulShot();
    }
}