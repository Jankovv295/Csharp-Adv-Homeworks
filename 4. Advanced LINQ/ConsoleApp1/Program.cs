//Create a class Person and a class Dog. Each Person can have one or more dogs. Create properties according some of the requirements below. Create a static db, static lists of the two classes.

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Freddy`s dogs names older than 3 years
//Find and print Nathen`s first dog
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER


using ConsoleApp1.Entitites;

#region 1 tocka
List<Person> NameStarsWithROrderedByAge = DataBase.Persons.Where(x => x.Name.StartsWith("R")).OrderByDescending(x => x.Age).ToList();

Console.WriteLine("All persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER:");
NameStarsWithROrderedByAge.PrintName(ConsoleColor.Green);
#endregion


#region 2 tocka
List<Dog> BrownDogNames = DataBase.Dogs.Where(x => x.Color.ToLower() == "brown")
    .Where(a => a.Age > 3).OrderBy(order => order.Age).ToList();

Console.WriteLine("\nAll brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER:");
BrownDogNames.PrintName(ConsoleColor.Red);
#endregion


#region 3 tocka
List<Person> PeopleWithMoreThan1Dog = DataBase.Persons.Where(x => x.DogList.Count > 1)
    .OrderByDescending(x => x.Name).ToList();

Console.WriteLine("\nAll persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
PeopleWithMoreThan1Dog.PrintEntities(ConsoleColor.Yellow);
#endregion


#region 4 tocka
List<Dog> FreddysDogsOlderThan1 = DataBase.Persons
    .Where(x => x.Name == "Freddy")
    .SelectMany(x => x.DogList.Where(y => y.Age > 3))
    .ToList();


Console.WriteLine("\nAll Freddy`s dogs names older than 3 years");
FreddysDogsOlderThan1.PrintName(ConsoleColor.Magenta);

#endregion


#region 5 tocka
Dog NathensFirstDog = DataBase.Persons.Where(x => x.Name == "Nathen")
    .Select(x => x.DogList.FirstOrDefault()).FirstOrDefault();

Console.WriteLine("\nNathens First Dog:");
Console.ForegroundColor = ConsoleColor.Blue;
NathensFirstDog.PrintInfo();
Console.ResetColor();
#endregion

#region 6 tocka
List<Person> GolemaE = DataBase.Persons.Where(x => x.Name == "Cristofer" || x.Name == "Freddy" || x.Name == "Erin" || x.Name == "Amelia").Where(x => x.DogList.Any(y => y.Color == "white")).ToList(); 
Console.WriteLine("\nAll white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");
GolemaE.PrintName(ConsoleColor.Cyan);

#endregion

