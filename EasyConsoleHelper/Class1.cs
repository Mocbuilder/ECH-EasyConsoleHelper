namespace EasyConsoleHelper
{
    public class ECH
    {
        public static void ColorPrint(string toPrint, ConsoleColor color)
        {
            ConsoleColor origColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(toPrint);
            Console.ForegroundColor = origColor;
        }

        public static void ErrorPrint(string message)
        {
            ColorPrint($"Error: {message}", ConsoleColor.Red);
        }
    }
}
