namespace ConsoleApp1.Entities
{
    public class JapaneseCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"The Japanese Car {Brand} is travelling to {destinationName}");
        }
    }
}
