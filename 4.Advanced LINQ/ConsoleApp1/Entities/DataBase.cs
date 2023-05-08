namespace ConsoleApp1.Entities
{
    public static class DataBase
    {
        public static List<Person> Persons { get; set; }
        public static List<Dog> Dogs { get; set; }

        static DataBase()
        {
            Dogs = new List<Dog>()
            {
            new Dog("Max", 4, "brown"),
            new Dog("Luna", 1, "white"),
            new Dog("Bella", 8, "gold"),
            new Dog("Sharko", 2, "black"),
            new Dog("Daisy", 4, "brown"),
            new Dog("Charlie", 3, "white"),
            new Dog("Zoe", 5, "black"),
            new Dog("Rocky", 3, "orange"),
            new Dog("Nala", 7, "white"),
            new Dog("Mia", 1, "gray"),
            new Dog("Coco", 2, "gold"),
            new Dog("Stella", 5, "brown")
            };
            Persons = new List<Person>()
                {
                    new Person("Robert", "Robertovski", 24, new List<Dog>() { Dogs[0], Dogs[1] }),
                    new Person("Freddy", "Mercury", 24, new List<Dog>() { Dogs[2] }),
                    new Person("Nathen", "Nathenov", 24, new List<Dog>() { Dogs[3], Dogs[4], Dogs[5] }),
                    new Person("Cristofer", "Markovski", 24, new List<Dog>() { Dogs[6] }),
                    new Person("Erin", "Johnson", 24, new List<Dog>() { Dogs[7] }),
                    new Person("Amelia", "Lens", 24, new List<Dog>() { Dogs[8], Dogs[9] }),
                    new Person("Rob", "Bobovski", 24, new List<Dog>() { Dogs[10], Dogs[11] }),
                };
        }
    }
}