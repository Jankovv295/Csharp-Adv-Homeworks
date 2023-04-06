using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Models.Interfaces;

namespace Task_1.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public bool IsBreathing { get; set; }
        public Animal() { }
        public Animal(string name, string color, bool isBreathing)
        {
            Name = name;
            Color = color;
            IsBreathing = isBreathing;
        }

        public abstract void PrintAnimal();
    }
}
