using System;

namespace WCFTestFramework.Extensions
{
    public static class ConsoleEx
    {
        public static void WriteLineWithColor(string message, ConsoleColor foreColor = ConsoleColor.White, ConsoleColor backColor = ConsoleColor.Black)
        {
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
