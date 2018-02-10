using System;

namespace Cliff
{
    class World
    {
        static void Main(string[] args)
        {
            StartAdventure();
        }

        private static void StartAdventure()
        {
            Player p = new Player();

            while (true)
            {
                GUI.Draw(p);

                Entity.UpdateHealth(p, -1);

                Console.ReadKey();
            }
        }
    }
}
