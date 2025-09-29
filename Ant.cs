using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Ant : Enemy
    {
        private int ChargeDistance;

        public Ant(string name, int health, ConsoleColor color, int chargeDistance)
            : base(name, health, color, ArtAssets.Ant)
        {
            ChargeDistance = chargeDistance;
        }

        public void Charge()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" charges swiftly forward {ChargeDistance} inches!");
        }

        public void Bite()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" viciously chomps down!");
        }
    }
}
