using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Bee
    {
        private string Name;
        private double Health;
        private string TextArt;
        private ConsoleColor Color;

        public Bee(string name, int health, ConsoleColor color)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = ArtAssets.Bee;
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
