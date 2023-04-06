using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Models.Interfaces;

namespace Task_2.Models
{
    public abstract class Vehicle : IRepairService
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public Vehicle(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }
        public abstract void Drive();

        public void CheckVehicle()
        {
            Console.WriteLine("The vehicle is being checked");
        }

        public void FixVehicle()
        {
            Console.WriteLine("The vehicle is in good condition, doesn't need to be fixed!");
        }
    }
}
