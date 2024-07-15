namespace Calculatrice_1.Calculatrice
{
    internal class Utils
    {
        /// <summary>
        /// La fonction <c>InputInt</c> récupere un nombre saisi par l'utilisateur passé par des filtres.
        /// </summary>
        /// <param name="messageInput">
        /// Le paramètre <c>messageInput</c> est le message a afficher pour la saisi de l'utilisateur.
        /// </param>
        /// <param name="messageError">
        /// Le paramètre <c>messageError</c> est le message a afficher si l'utilisateur ne respecte pas la saisi.
        /// </param>
        /// <returns>
        /// Renvoie le nombre valide saisie par l'utilisateur.
        /// </returns>
        public static decimal InputDecimal(string messageInput, string messageError)
        {
            Console.Write(messageInput);
            bool existInt = decimal.TryParse(Console.ReadLine(), out decimal result);
            while (!existInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existInt = decimal.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        /// <summary>
        /// La fonction <c>InputInt</c> récupere un nombre saisi par l'utilisateur passé par des filtres.
        /// </summary>
        /// <param name="messageInput">
        /// Le paramètre <c>messageInput</c> est le message a afficher pour la saisi de l'utilisateur.
        /// </param>
        /// <param name="messageError">
        /// Le paramètre <c>messageError</c> est le message a afficher si l'utilisateur ne respecte pas la saisi.
        /// </param>
        /// <returns>
        /// Renvoie le nombre valide saisie par l'utilisateur.
        /// </returns>
        public static int InputInt(string messageInput, string messageError)
        {
            Console.Write(messageInput);
            bool existInt = int.TryParse(Console.ReadLine(), out int result);
            while (!existInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existInt = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        /// /// <summary>
        /// La fonction <c>InputString</c> récupere la chaîne de caractère saisi par l'utilisateur passer par des filtres.
        /// </summary>
        /// <param name="messageInput">
        /// Le paramètre <c>messageInput</c> est le message a afficher pour la saisi de l'utilisateur.
        /// </param>
        /// <param name="messageError">
        /// Le paramètre <c>messageError</c> est le message a afficher si l'utilisateur ne respecte pas la saisi.
        /// </param>
        /// <param name="isEmptyOrNull">
        /// Le paramètre <c>isEmptyOrNull</c> est un booléen qui défini si le chaîne de caratère saisi par l'utilisateur n'est pas vide ou null.
        /// </param>
        /// <param name="container">
        /// Le paramètre <c>container</c> est une liste de chaîne auquel l'utilisateur à le choix.
        /// </param>
        /// <returns>
        /// Renvoie la chaîne de caratère valide saisie par l'utilisateur.
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
