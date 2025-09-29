using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Ant
    {
        private string Name;
        private int Health;
        private string TextArt;
        private ConsoleColor Color;
        private int ChargeDistance;

        public Ant(string name, int health, ConsoleColor color, int chargeDistance)
        {
            Name = name;
            Health = health;
            Color = color;
            ChargeDistance = chargeDistance;
            TextArt = ArtAssets.Ant;
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"--- {Name} ---");
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health: {Health}");
            WriteLine("---");
            ResetColor();
        }
    }
}
