using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Models.Interfaces;

namespace Task_1.Models
{
    public class Cat : Animal, ICat
    {
        public Cat()
        {
        }

        public Cat(string name, string color, bool isBreathing, bool hasFur, string race) : base(name, color, isBreathing)
        {
            HasFur = hasFur;
            Race = race;
        }

        public bool HasFur { get; set; }

        public string Race { get; set; }

        
        public void Eat(string food)
        {
            Console.WriteLine($"The Cat eats {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The Cat is called {Name}, is {Race} and has {Color} color");
        }
    }
}
