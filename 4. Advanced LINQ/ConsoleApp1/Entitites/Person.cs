using System.Diagnostics;

namespace ConsoleApp1.Entitites
{
    public class Person : BaseEntity
    {
        public Person()
        {
        }

        public string LastName { get; set; } = string.Empty;

        public List<Dog> DogList { get; set; } = new List<Dog>();

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {LastName} has {Age} years");
        }
    }
}
