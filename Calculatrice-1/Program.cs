using Calculatrice_1.Calculatrice;

string strErreur = "\tErreur de saisie, veuillez saisir un nombre.";
string strOperande = "Saisissez un nombre : ";
string strOperateur = "Saisissez votre opérateur (*, /, -, +) et pour quitter (q/Q) : ";

void Calculator()
{
    bool isEnd = false;
    Calculatrice calcul = new Calculatrice();
    calcul.Reset();
    do
    {
        decimal lastRes = calcul.Resultat;
        if (calcul.Resultat == 0)
        {
            calcul.Resultat = Utils.InputDecimal(strOperande, strErreur);
            lastRes = calcul.Resultat;
        }
                
        string? operateur = Utils.InputString(strOperateur, "\tErreur de saisie, veuillez saisir un opérateur", true, ["q","Q","-","+","/","*"]);
        if (operateur?.ToUpper() == "Q")
        {
            Console.ReadKey();
            Console.Clear();
            return;
        }
                
        calcul.Operande2 = Utils.InputDecimal(strOperande, strErreur);
        bool isDivisible = true;

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
                if (calcul.Operande2 != 0)
                {
                    calcul.Division();
                    operateur1 = "/";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tVous ne pouvez pas diviser par 0");
                    Console.ForegroundColor = ConsoleColor.White;
                    isDivisible = false;
                }
                break;
            case "+":
                calcul.Addition();
                operateur1 = "+";
                break;
            default:
                break;
        }
        if (isDivisible)
        {
            Console.WriteLine($"{lastRes} {operateur1} {calcul.Operande2} = {calcul.Resultat}");
        }
    } while (!isEnd);

    Console.ReadKey();
    Console.Clear();
}

void DisplayMenu()
{
    bool isEnd = false;
    do
    {
        string menu = "--- Calculatrice ---\n\n[0] Quitter\n[1] Commencer\n";

        int choice = Utils.InputInt(menu, strErreur);
        switch (choice)
        {
            case 0:
                isEnd=true;
                break;
            case 1:
                Console.Clear();
                Calculator();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(strErreur);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                break;
        }
    } while (!isEnd);
}

DisplayMenu();