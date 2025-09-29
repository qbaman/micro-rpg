using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGameDemo
{
    class Ant
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Ant(string name)
        {
            Name = name;
            Health = 20;
            AttackPower = 5;
        }

        public void Display()
        {
            Console.WriteLine(ArtAssets.Ant);
            Console.WriteLine($"Name: {Name} | Health: {Health} | Attack: {AttackPower}\n");
        }

        public void Attack(Ant target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
            target.Health -= AttackPower;
            if (target.Health <= 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!\n");
            }
        }
    }
}
