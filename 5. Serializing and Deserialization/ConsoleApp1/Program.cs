//Create a Dog class with :
//Name, Age, Color
//Let the user input these parameters from a console application
//Create a new Dog object from the inputs and write it as a json in a new file on the file system
//The content of the json should be array
//Create a method that reads and prints in the console all the dogs from the txt file

using ConsoleApp1;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

#region File System
string FolderPath = "../../../JsonFolder";
string FilePath = FolderPath + "/DogObjects.json";

if (!Directory.Exists(FolderPath))
{
    Directory.CreateDirectory(FolderPath);
}

if (!File.Exists(FilePath))
{
    File.Create(FilePath).Close();
}

void WriteToJson(string json)
{
    using(StreamWriter sw = new StreamWriter(FilePath, true))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson()
{
    using(StreamReader sr = new StreamReader(FilePath))
    {
        Console.WriteLine("\n" + sr.ReadToEnd());
    }
}
#endregion

Console.Write("Enter the Name of the Dog: ");
string nameInput = Console.ReadLine();

Console.Write("Enter the Age of the Dog: ");
int ageInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Color of the Dog: ");
string colorInput = Console.ReadLine();

Dog inputDog = new Dog()
{
    Name = nameInput,
    Age = ageInput,
    Color = colorInput
};

string serializedInputDog = JsonConvert.SerializeObject(inputDog);
WriteToJson(serializedInputDog);

Dog deserializedInputDog = JsonConvert.DeserializeObject<Dog>(serializedInputDog);
ReadFromJson();

