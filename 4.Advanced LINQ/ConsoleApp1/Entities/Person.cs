namespace ConsoleApp1.Entities
{
    public class Person : BaseEntity
    {

        public string LastName { get; set; } = string.Empty;    


        public List<Dog>? Dogs { get; set; } = new List<Dog>();

        public Person(string Name, string lastName, int age, List<Dog> dogs)
        {
            Name = Name;
            LastName = lastName;
            Age = age;
            Dogs = dogs;
        }
    }
}

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Freddy`s dogs names older than 1 year
//Find and print Nathen`s first dog
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER