using System;
using System.Collections.Generic;
using System.Text;

namespace Cliff.Utils
{
    static class GUI
    {
        public static void Draw(Cliff.Player p)
        {
            Console.WriteLine(p.Level + " - " + p.Hp_current + " - " + p.Speed);

        }
    }
}
