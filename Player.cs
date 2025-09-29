using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Player : Character
    {
        public Player(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Player)
        {

        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"Player {Name} attacks ....");
            ResetColor();
        }
    }
}
