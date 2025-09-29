using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
<<<<<<< HEAD
    class BeeAnt
    {
        private string Name;
        private double Health;
        private string TextArt;
        private ConsoleColor Color;

        public BeeAnt(string name, int health, ConsoleColor color)
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
=======
    internal class Bee : Character
    {
        private bool HasPosionSting;

        public Bee(string name, int health, ConsoleColor color, bool hasPoisonSting)
            : base(name, health, color, ArtAssets.Bee)
        {
            HasPosionSting = hasPoisonSting;
        }

        public void Fly()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" takes to the air!");
        }

        public void Sting()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            Write(" lunges forward with their ");
            if (HasPosionSting)
            {
                WriteLine("poison stinger!");
            }
            else
            {
                WriteLine("sharp stinger!");
            }
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"Ant {Name} is fighting!");
            ResetColor();
            int randNum = RandGenerator.Next(1, 101);
            if (randNum <= 50)
            {
                Fly();
            }
            else
            {
                Sting();
            }
        }
    }
}
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
