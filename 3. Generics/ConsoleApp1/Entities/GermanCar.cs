namespace ConsoleApp1.Entities
{
    public class GermanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"The German Car {Brand} is going to {destinationName}");
        }
    }
}
