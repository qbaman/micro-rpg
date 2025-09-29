using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
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