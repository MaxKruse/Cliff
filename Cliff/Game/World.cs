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
            Entity Player = new Entity();

            while (true)
            {
                GUI.Draw(Player);

                Player.UpdateHealth(-1);

                Console.ReadKey();
            }
        }
    }
}
