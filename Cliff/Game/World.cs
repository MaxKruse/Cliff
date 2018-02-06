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
            Player p = new Player(1, 50, 100, 0, 0, 0, 100, 0, 15, 0, 15, 0, 15, 0, 15, 0, 30, 0, 0, 1);

            while (true)
            {
                Utils.GUI.Draw(p);
                Console.ReadKey();
            }
        }
    }
}
