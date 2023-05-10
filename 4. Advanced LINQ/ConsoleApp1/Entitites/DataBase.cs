namespace ConsoleApp1.Entitites
{
    public static class DataBase
    {
        //public static List<Person> Persons { get; set; }

        //public static List<Dog> Dogs { get; set; }

            public static List<Dog> Dogs = new List<Dog>()
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
            new Dog("Stella", 5, "brown"),
            new Dog("Bailey", 2, "blue"),
            new Dog("Sadie", 5, "red")
            };

            public static List<Person> Persons = new List<Person>()
            {
            new Person("Robert", "Robertovski", 24),
            new Person("Freddy", "Mercury", 23),
            new Person("Nathen", "Nathenov", 18),
            new Person("Cristofer", "Markovski", 35),
            new Person("Erin", "Johnson", 48),
            new Person("Amelia", "Lens", 12),
            new Person("Rob", "Bobovski", 25),
            };
        static DataBase()
        {
            Persons[0].DogList = new List<Dog> { Dogs[0], Dogs[1]};
            Persons[1].DogList = new List<Dog> { Dogs[2], Dogs[12], Dogs[13], };
            Persons[2].DogList = new List<Dog> { Dogs[3], Dogs[4], Dogs[5]};
            Persons[3].DogList = new List<Dog> { Dogs[6]};
            Persons[4].DogList = new List<Dog> { Dogs[7]};
            Persons[5].DogList = new List<Dog> { Dogs[8], Dogs[9] };
            Persons[6].DogList = new List<Dog> { Dogs[10], Dogs[11] };
        }
    }
}
