using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.Design;
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Game
    {
<<<<<<< HEAD
        private Ant FireAuntie;
        private Ant Hades;

        public Game()
        {
            FireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);
            Hades = new Ant("Hades", 200, ConsoleColor.Magenta, 6);
=======
        private Player CurrentPlayer;
        private List<Character> Enemies;

        public Game()
        {
            Ant FireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);

            Ant hades = new Ant("Hades", 200, ConsoleColor.Magenta, 6);
            Item leafNinjaStar = new Item("Leaf Ninja Star", 3);
            hades.PickUpItem(leafNinjaStar);

            Bee BuzzBee = new Bee("Buzz Bee", 50, ConsoleColor.Yellow, true);

            // polymorphism - a list of Enemy objects can hold Ant and Bee objects
            Enemies = new List<Character> { FireAuntie, hades, BuzzBee };
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
        }

        public void Run()
        {
            WriteLine("##### Micro RPG #####\n");

<<<<<<< HEAD
            FireAuntie.DisplayInfo();
            WriteLine();
            FireAuntie.Charge();
            FireAuntie.Bite();
            WriteLine();

            Hades.DisplayInfo();
            WriteLine();
            Hades.Charge();
            Hades.Bite();
            WriteLine();
=======
            CurrentPlayer = new Player("The Hero", 300, ConsoleColor.DarkCyan);
            CurrentPlayer.DisplayInfo();

            //CurrentPlayer.Fight(Enemies[0]);
            //Enemies[0].Fight(CurrentPlayer);
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }
    }
}
