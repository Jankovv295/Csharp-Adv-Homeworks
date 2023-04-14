namespace ConsoleApp1.Entities
{
    public static class Extension_methods
    {
        public static void ChangeColorOfText(this string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
