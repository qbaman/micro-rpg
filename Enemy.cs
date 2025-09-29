using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    internal class Enemy
    {
        private string Name;
        private double Health;
        private string TextArt;
        private ConsoleColor Color;
        private int ChargeDistance;

        public Enemy(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
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
