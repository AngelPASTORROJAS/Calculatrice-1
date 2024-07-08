using Calculatrice_1.Calculatrice;

class Program
{
    static void Main()
    {
        void Calculator()
        {
            bool isEnd = false;
            string strOperande = "Saisissez un nombre : ";
            string strOperateur = "Saisissez votre opérateur (*, /, -, +) et pour quitter (q/Q) : ";
            Calculatrice calcul = new Calculatrice();
            calcul.Reset();
            do
            {
                decimal lastRes = calcul.Resultat;
                if (calcul.Resultat == 0)
                {
                    Console.Write(strOperande);
                    calcul.Operande1 = Convert.ToDecimal(Console.ReadLine());
                    calcul.Resultat = calcul.Operande1;
                    lastRes = calcul.Resultat;
                }
                Console.Write(strOperateur);
                string? operateur = Console.ReadLine();
                if (operateur?.ToUpper() == "Q")
                {
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                
                Console.Write(strOperande);
                calcul.Operande2 = Convert.ToDecimal(Console.ReadLine());

                string operateur1 = "";
                switch (operateur)
                {
                    case "*":
                        calcul.Multiplicateur();
                        operateur1 = "*";
                        break;
                    case "-":
                        calcul.Soustraction();
                        operateur1 = "-";
                        break;
                    case "/":
                        calcul.Division();
                        operateur1 = "/";
                        break;
                    case "+":
                        calcul.Addition();
                        operateur1 = "+";
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"{lastRes} {operateur1} {calcul.Operande2} = {calcul.Resultat}");
            } while (!isEnd);

            Console.ReadKey();
            Console.Clear();
        }

        void DisplayMenu()
        {
            string erreurSaisie = "\tErreur de saisie, faites un choix valide!";
            bool isEnd = false;
            do
            {
                string menu = "--- Calculatrice ---\n\n";
                menu += "[0] Quitter\n";
                menu += "[1] Commencer\n";

                Console.WriteLine(menu);
                bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 0:
                        if (isValidChoice)
                        {
                            isEnd=true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 1:
                        Console.Clear();
                        Calculator();
                        break;
                    default:
                        Console.WriteLine(erreurSaisie);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if (!isValidChoice)
                {
                    Console.WriteLine(erreurSaisie);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isEnd);
        }
        DisplayMenu();
    }
}