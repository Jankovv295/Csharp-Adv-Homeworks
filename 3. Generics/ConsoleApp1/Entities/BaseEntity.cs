using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public int HorsePower { get; set; }

        public FuelType FuelType { get; set; }

        public abstract void Drive(string destinationName);
    }
}


//properties Id, Brand, Model, MaxSpeed, HorsePower, FuelType and a abstract method Drive(string destinationName).