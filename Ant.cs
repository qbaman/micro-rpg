using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
<<<<<<< HEAD
    class Ant : Enemy
    {
        private int ChargeDistance;
=======
    class Ant : Character
    {
        private int ChargeDistance;
        private Item CurrentItem;
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)

        public Ant(string name, int health, ConsoleColor color, int chargeDistance)
            : base(name, health, color, ArtAssets.Ant)
        {
            ChargeDistance = chargeDistance;
        }

<<<<<<< HEAD
=======
        public void PickUpItem(Item item)
        {
            CurrentItem = item;
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" picks up {item.Quantity} {item.Name}(s)!");
        }

>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
        public void Charge()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" charges swiftly forward {ChargeDistance} inches!");
<<<<<<< HEAD
=======

            if (CurrentItem != null)
            {
                WriteLine($"They are carrying a {CurrentItem.Name}.");
            }
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
        }

        public void Bite()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" viciously chomps down!");
        }
<<<<<<< HEAD
=======

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"Ant {Name} is fighting!");
            int randNum = RandGenerator.Next(1, 101);
            if (randNum <= 50)
            {
                Charge();
            }
            else
            {
                Bite();
            }
            ResetColor();
        }
>>>>>>> 9771d90 (feat: implement fight mechanics for Player and Ant)
    }
}
