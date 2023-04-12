//###Homework Generics
//Crate a car dealership app. Make a BaseEntity abstract class with properties Id, Brand, Model, MaxSpeed, HorsePower, FuelType and a abstract method Drive(string destinationName).
//Create other classes for JapaneseCar, GermanCar, FrenchCar, ItalianCar, AmericanCar that will inherit from the BaseEntity.
//Make a generic database named GenericDb that will only take in classes that INHERIT FROM THE BaseEntity.

//In the generic database create methods for Inserting a car, Get a car by id, Print all cars.
//Create an extension method that will change the color of a text, just like we learned in class.


using ConsoleApp1.DataBase;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;


GenericDb<AmericanCar>.Insert(new AmericanCar
{
    Id = 2,
    Brand = "Chevrolet",
    Model = "Camaro",
    FuelType = FuelType.Diesel,
    HorsePower = 500,
    MaxSpeed = 280,
});

GenericDb<AmericanCar>.Insert(new AmericanCar
{
    Id = 1,
    Brand = "Ford",
    Model = "Focus",
    FuelType = FuelType.Petrol,
    HorsePower = 300,
    MaxSpeed = 260,
});

GenericDb<AmericanCar>.PrintAll();

GermanCar s63 = new GermanCar
{
    Id = 3,
    Brand = "Mercedes",
    Model = "S63",
    FuelType = FuelType.Petrol,
    HorsePower = 350,
    MaxSpeed = 280
};
s63.Drive("Napoli");


while (true)
{
    Console.WriteLine("Enter the ID of the car");
    int idInput = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Brand of the car");
    string brandInput = Console.ReadLine();

    Console.WriteLine("Enter the Model of the car");
    string modelInput = Console.ReadLine();

    Console.WriteLine("Enter 1-4 to choose the FuelType of the car \n1.) Petrol \n2.)Diesel \n3.)Hybrid \n4.)Electric");
    int chooseFuelType = Convert.ToInt32(Console.ReadLine());

    FuelType fuelType = FuelType.Electric;
    switch (chooseFuelType)
    {
        case 1:
            fuelType = FuelType.Petrol;
            break;
        case 2:
            fuelType = FuelType.Diesel;
            break;
        case 3:
            fuelType = FuelType.Hybrid;
            break;
        case 4:
            fuelType = FuelType.Electric;
            break;
        default:
            Console.WriteLine("You have entered invalid number, try 1-4");
            break;
    }
    Console.WriteLine("Enter the Horse Power of the car");
    int horsePowerInput = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Max speed of the car");
    int maxSpeedInput = Convert.ToInt32(Console.ReadLine());

    GenericDb<ItalianCar>.Insert(new ItalianCar()
    {
        Id = idInput,
        Brand = brandInput,
        Model = modelInput,
        FuelType = fuelType,
        HorsePower = horsePowerInput,
        MaxSpeed = maxSpeedInput
    });

    Console.WriteLine("If you want to exit press X, if you want to continue press enter");
    string exitOrContinue = Console.ReadLine();

    if (exitOrContinue.ToLower() == "x")
    {
        Console.WriteLine("\n");
        GenericDb<ItalianCar>.PrintAll();
        break;
    }
}