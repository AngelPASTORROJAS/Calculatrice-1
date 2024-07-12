using Calculatrice_1.Calculatrice;

/* These lines of code are initializing string variables with messages that will be displayed to the
user during the interactive calculator program execution. */
string strErreur = "\tErreur de saisie, veuillez saisir un nombre.";
string strOperande = "Saisissez un nombre : ";
string strOperateur = "Saisissez votre opérateur (*, /, -, +) et pour quitter (q/Q) : ";

/// <summary>
/// The function `Calculator` allows the user to perform basic arithmetic operations interactively using
/// a custom `Calculatrice` class.
/// </summary>
/// <returns>
/// The `Calculator()` function returns void, which means it does not return any value. It performs
/// calculations and displays results within the function, but it does not return any specific value to
/// the calling code.
/// </returns>
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
            calcul.Operande1 = Utils.InputDecimal(strOperande, strErreur);
            calcul.Resultat = calcul.Operande1;
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

/// <summary>
/// The DisplayMenu function displays a menu for a calculator program and allows the user to choose
/// between quitting or starting the calculator.
/// </summary>
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

/* `DisplayMenu();` is a function that displays a menu for a calculator program. It
allows the user to choose between quitting the program or starting the calculator functionality. The
function prompts the user with options to either quit or begin using the calculator. Depending on
the user's choice, it either exits the program or calls the `Calculator()` function to perform
arithmetic operations interactively. */
DisplayMenu();