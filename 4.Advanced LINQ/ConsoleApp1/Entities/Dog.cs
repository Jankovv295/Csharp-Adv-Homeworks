﻿namespace ConsoleApp1.Entities
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
    }
}

//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Freddy`s dogs names older than 1 year
//Find and print Nathen`s first dog
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER