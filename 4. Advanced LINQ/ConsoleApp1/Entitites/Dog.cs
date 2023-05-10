namespace ConsoleApp1.Entitites
{
    public class Dog : BaseEntity
    {

        public string Color { get; set; } = string.Empty;

        public Person Person { get; set; }  

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} with color {Color} is {Age} years old.");
        }
    }
}
