using System;
using TowerDefense.Invaders;
using TowerDefense.Towers;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new GuardianInvader(path),
                    new BasicInvader(path),
                    new RessurectingInvader(path)
                };

                ITower[] towers = {
                    new BasicTower(new MapLocation(1, 3, map)),
                    new PowerfulTower(new MapLocation(3, 3, map)),
                    new SniperTower(new MapLocation(5, 3, map)),
                    new CatapultTower(new MapLocation(7, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (TowerDefenceException)
            {
                Console.WriteLine("Unhandled TowerDefenceException");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception" + ex);
            }
        }
    }
}
