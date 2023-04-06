﻿//Task 1: Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//The implementation for the methods is on your choice.


using Task_1.Models;

Dog sharko = new Dog("Sharko", "Brown", true, "Golden Retriver");
//sharko.PrintAnimal();
//sharko.Bark();

Cat mia = new Cat("Mia", "Gray", true, true, "Siamese Cat");
//mia.Eat("fish");
//mia.PrintAnimal();