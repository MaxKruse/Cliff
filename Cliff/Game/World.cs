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
            EntityManager CharacterManager = new EntityManager();

            Entity Player = CharacterManager.CreateCharacter();

            while (true)
            {
                GUI.Draw(Player);

                Player.UpdateHealth(-1);

                Console.ReadKey();
            }
        }
    }
}
