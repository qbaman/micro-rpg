using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Game
    {
        private Ant FireAuntie;
        public Game()
        {
            FireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);
        }

        public void Run()
        {
            WriteLine("##### Micro RPG #####\n");

            FireAuntie.DisplayInfo();

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }
    }
}

