using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_1.Calculatrice
{
    internal class Utils
    {
        /// <summary>
        /// The function `InputDecimal` reads a decimal input from the user with optional positive
        /// number validation and error messages.
        /// </summary>
        /// <param name="messageInput">The `messageInput` parameter is a string that represents the
        /// message prompting the user to input a decimal number.</param>
        /// <param name="messageError">The `messageError` parameter is a string that contains the error
        /// message to be displayed when the user enters invalid input (e.g., non-numeric input) while
        /// trying to input a decimal value.</param>
        /// <param name="isPositive">The `isPositive` parameter in the `InputDecimal` method is a
        /// boolean parameter that determines whether the input decimal number should be positive or
        /// not. If `isPositive` is set to `true`, it means that the method expects the input decimal
        /// number to be positive. If the input is negative</param>
        /// <returns>
        /// This method returns a decimal value that is input by the user after displaying the specified
        /// input message. If the input is not a valid decimal or does not meet the specified conditions
        /// (such as being positive when required), an error message is displayed, and the user is
        /// prompted to input again until a valid decimal value is provided.
        /// </returns>
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

        /// <summary>
        /// The function `InputInt` reads an integer input from the user with error handling and
        /// optional positive number validation.
        /// </summary>
        /// <param name="messageInput">The `messageInput` parameter is a string that represents the
        /// message prompting the user to input an integer.</param>
        /// <param name="messageError">The `messageError` parameter in the `InputInt` method is a string
        /// that represents the error message displayed when the user enters invalid input (e.g.,
        /// non-integer input).</param>
        /// <param name="isPositive">The `isPositive` parameter in the `InputInt` method is a boolean
        /// parameter that determines whether the input integer should be positive or not. If
        /// `isPositive` is set to `true`, the method will ensure that the input integer is a positive
        /// number. If `isPositive` is set</param>
        /// <returns>
        /// The method `InputInt` returns an integer value that is input by the user after validating it
        /// based on the specified conditions.
        /// </returns>
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

        /// <summary>
        /// The function `InputString` takes user input, validates it based on specified conditions, and
        /// returns the input as a string.
        /// </summary>
        /// <param name="messageInput">The `messageInput` parameter is the message that will be
        /// displayed to prompt the user for input.</param>
        /// <param name="messageError">The `messageError` parameter in the `InputString` method is used
        /// to display an error message when the input provided by the user does not meet the specified
        /// criteria or conditions. This message is shown to the user in case of an error, prompting
        /// them to correct their input.</param>
        /// <param name="isEmptyOrNull">The `isEmptyOrNull` parameter in the `InputString` method is a
        /// boolean flag that determines whether the input string can be empty or null. If
        /// `isEmptyOrNull` is set to `true`, the method will keep prompting the user for input until a
        /// non-empty string is provided. If `isEmpty</param>
        /// <param name="container">The `container` parameter in the `InputString` method is an optional
        /// parameter that allows you to pass an array of strings. This parameter is used to validate
        /// the user input against the values in the `container` array. If the `container` array is
        /// provided and the user input does not match</param>
        /// <returns>
        /// The `InputString` method returns a string value. If the input string is empty or null and
        /// the `isEmptyOrNull` parameter is set to true, it will keep prompting the user with an error
        /// message until a non-empty string is entered. If the `container` parameter is provided with
        /// an array of strings, it will validate that the input string is contained within that array,
        /// and if not,
        /// </returns>
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
