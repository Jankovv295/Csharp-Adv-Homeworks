using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Entitites
{
    public static class ListHelper
    {
        public static void PrintEntities<T>(this List<T> list, ConsoleColor color) where T : BaseEntity
        {
            foreach (T item in list)
            {
                Console.ForegroundColor = color;
                item.PrintInfo();
                Console.ResetColor();
            }
        }
        public static void PrintName<T>(this List<T> list, ConsoleColor color) where T : BaseEntity
        {
            foreach (T item in list)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(item.Name);
                Console.ResetColor();
            }
        }

    }
}
