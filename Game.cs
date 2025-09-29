using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Game
    {
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
        }

        public void Run()
        {
            WriteLine("##### Micro RPG #####\n");

            CurrentPlayer = new Player("The Hero", 300, ConsoleColor.DarkCyan);
            CurrentPlayer.DisplayInfo();

            //CurrentPlayer.Fight(Enemies[0]);
            //Enemies[0].Fight(CurrentPlayer);

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }
    }
}
