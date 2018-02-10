using System;
using System.Collections.Generic;
using System.Text;

namespace Cliff
{
    static class GUI
    {
        public static void Draw(Cliff.Entity p)
        {
            Console.WriteLine(p.Level + " - " + p.Hp_current + " - " + p.Speed);

        }
    }
}
