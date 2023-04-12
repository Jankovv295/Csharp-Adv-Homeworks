using ConsoleApp1.Entities;

namespace ConsoleApp1.DataBase
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db;

        static GenericDb()
        {
            Db = new List<T>();
        }

        public static void Insert(T entity)
        {
            Db.Add(entity);
        }

        public static T GetById(int id)
        {
            return Db.FirstOrDefault(x => x.Id == id);
        }


        public static void PrintAll()
        {
            foreach (T element in Db)
            {
                Console.WriteLine($"Car: {element.Brand} {element.Model}, Max Speed |{element.MaxSpeed}|, Horse Power |{element.HorsePower}| and Fuel Type {element.FuelType}");
            }
        }
    }
}
