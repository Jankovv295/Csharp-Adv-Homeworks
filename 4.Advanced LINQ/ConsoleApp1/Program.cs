//Create a class Person and a class Dog. Each Person can have one or more dogs. Create properties according some of the requirements below. Create a static db, static lists of the two classes.

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Freddy`s dogs names older than 1 year
//Find and print Nathen`s first dog
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

using ConsoleApp1.Entities;



var personstartwithrdescorder = database.persons.where(x => x.name.startswith("r"))
                                                .select(x => x.name);

foreach (var item in personstartwithrdescorder)
{
    //console.writeline(item);
}

var personi = database.persons.select(x => x.name);
foreach (var item in personi)
{
    console.writeline(item);
}

var kucinja = database.dogs.select(x => x.name);
foreach (var item in kucinja)
{
    console.writeline(item);
}


//var personsStartingWithR = DataBase.Persons
//      .Where(p => p.Name.StartsWith("R"))
//      .OrderByDescending(p => p.Age)
//      .ToList();

//Console.WriteLine("Persons starting with 'R', ordered by age (descending):");
//foreach (var person in personsStartingWithR)
//{
//    Console.WriteLine($"{person.Name} {person.LastName}, Age: {person.Age}");
//}






//2
var brownDogsOlderThan3AscOrder = DataBase.Dogs.Where(x => x.Color == "brown" && x.Age > 3)
                                                .Select(x => x.Name);
foreach (var item in brownDogsOlderThan3AscOrder)
{
    //Console.WriteLine(item);
}
