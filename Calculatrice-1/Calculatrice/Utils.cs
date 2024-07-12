using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_1.Calculatrice
{
    internal class Utils
    {
        public static decimal InputDecimal(string messageInput, string messageError, bool isPositive = false)
        {
            Console.Write(messageInput);
            bool existInt = decimal.TryParse(Console.ReadLine(), out decimal result);
            if (isPositive && existInt)
            {
                existInt = existInt && result < 0;
            }
            while (!existInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existInt = decimal.TryParse(Console.ReadLine(), out result);
                if (isPositive && existInt)
                {
                    existInt = existInt && result < 0;
                }
            }
            return result;
        }

        public static int InputInt(string messageInput, string messageError, bool isPositive = false)
        {
            Console.Write(messageInput);
            bool existInt = int.TryParse(Console.ReadLine(), out int result);
            if (isPositive && existInt)
            {
                existInt = existInt && result < 0;
            }
            while (!existInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existInt = int.TryParse(Console.ReadLine(), out result);
                if (isPositive && existInt)
                {
                    existInt = existInt && result < 0;
                }
            }
            return result;
        }

        public static string InputString(string messageInput, string messageError, bool isEmptyOrNull = false, string[]? container = null)
        {
            Console.Write(messageInput);
            string? result = Console.ReadLine();
            if (isEmptyOrNull)
            {
                while (string.IsNullOrEmpty(result))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messageError);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(messageInput);
                    result = Console.ReadLine();
                }
            }
            if (container?.Any() ?? false)
            {
                while (!(container?.Contains(result)??false))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messageError);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(messageInput);
                    result = Console.ReadLine();
                }
            }
            return string.IsNullOrEmpty(result) ? "" : result;
        }
    }
}
