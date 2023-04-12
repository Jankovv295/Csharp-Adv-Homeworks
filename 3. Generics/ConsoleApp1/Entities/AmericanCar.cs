namespace ConsoleApp1.Entities
{
    public class AmericanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"The American Car {Brand} is travelling to {destinationName}");
        }
    }
}
