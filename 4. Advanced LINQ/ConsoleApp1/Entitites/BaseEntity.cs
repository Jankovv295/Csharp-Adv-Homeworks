namespace ConsoleApp1.Entitites
{
    public abstract class BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public abstract void PrintInfo();

    }
}
