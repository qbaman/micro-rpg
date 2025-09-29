using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Character
    {
        protected string Name;
        protected int Health;
        protected string TextArt;
        protected ConsoleColor Color;
        protected Random RandGenerator;


        public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
            RandGenerator = new Random();
        }

        public void DisplayInfo()
        {
            BackgroundColor = Color;
            Write($"             ---> {Name} <---              ");
            ResetColor();

            ForegroundColor = Color;
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health: {Health}");
            WriteLine("---");
            ResetColor();
        }

        public virtual void Fight(Character otherCharacter)
        {
            WriteLine("Enemy is fighting!");
        }  

    }
}
