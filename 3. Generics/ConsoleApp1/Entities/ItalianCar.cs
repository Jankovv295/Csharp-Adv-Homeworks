namespace ConsoleApp1.Entities
{
    public class ItalianCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"The Italian Car {Brand} is travelling to {destinationName}");
        }

    }
}
