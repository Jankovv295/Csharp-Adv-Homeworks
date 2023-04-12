namespace ConsoleApp1.Entities
{
    public class Car : Vehicle
    {

        public int FuelTank { get; set; }
        public string Countries { get; set; }
        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, string countries) : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }

        public Car()
        {
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type} | Produced in: {Countries}");
        }
    }
}

