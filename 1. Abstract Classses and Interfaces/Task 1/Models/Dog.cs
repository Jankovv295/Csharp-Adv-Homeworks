using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Models.Interfaces;

namespace Task_1.Models
{
    public class Dog : Animal, IDog
    {

        public string Breed { get; set; }
    
        public Dog(string name, string color, bool isBreathing, string breed) : base(name, color, isBreathing)
        {
            this.Breed = breed;
        }


        public void Bark()
        {
            Console.WriteLine("BARK BARK");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The Dog {Name} is {Color}");
        }
    }
}
