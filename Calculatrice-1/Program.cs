#region "Calculatrice 1"
/**
Console.WriteLine("--- Calculatrice ---\n");
string[] historique;
bool isValidInput = false;
string[] operateurs = ["-", "+", "*", "/", "mod", "pow"];
double result = 0;
Console.Write("Veuillez saisir votre nombre :");
bool isNumber = int.TryParse(Console.ReadLine(),out int number);
Console.WriteLine("Choissisez votre opérateur parmis :");
foreach (var operateur in operateurs)
{
    Console.WriteLine("\t"+operateur);
}
string operateurStr = Console.ReadLine();
Console.Write("Veuillez saisir votre nombre :");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int number2);

if (operateurStr == "-")
{
    result = number - number2;
} else if (operateurStr == "+")
{
    result = number + number2;
} else if (operateurStr == "*")
{
    result = number * number2;
} else if(operateurStr == "/")
{
    result = number / number2;
} else if (operateurStr == "mod")
{
    result = number % number2;
} else if (operateurStr == "pow")
{
    result = Math.Pow(number,number2);
}

Console.WriteLine($"{number} {operateurStr} {number2} = {result}");*/
#endregion


class Calculator
{
    public decimal Operande1 { get; set; }
    public decimal Operande2 { get; set; }
    public decimal Resultat { get; set; }

    public void Multiplicateur()
    {
        Resultat *= Operande2;
    }
    public void Soustraction()
    {
        Resultat -= Operande2;
    }
    public void Addition()
    {
        Resultat += Operande2;
    }
    public void Division()
    {
        Resultat = Decimal.Divide(Resultat,Operande2);
    }
    public void Reset()
    {
        Resultat = 0;
    }
}

class Program
{
    static void Main()
    {
        void Calculator()
        {
            bool isEnd = false;
            string strOperande = "Saisissez un nombre : ";
            string strOperateur = "Saisissez votre opérateur (*, /, -, +) et pour quitter (q/Q) : ";
            Calculator calcul = new Calculator();
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