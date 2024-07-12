namespace Calculatrice_1.Calculatrice
{
    /* The class "Calculatrice" contains methods for performing basic arithmetic operations on two
    operands and storing the result. */
    public class Calculatrice
    {
        /* These lines of code are defining properties for the class `Calculatrice`. Each property
        represents a decimal value that can be accessed and modified from outside the class. Here's
        what each property does: */
        public decimal Operande2 { get; set; }
        public decimal Resultat { get; set; }

        /// <summary>
        /// The function "Multiplicateur" multiplies the value of "Resultat" by the value of
        /// "Operande2".
        /// </summary>
        public void Multiplicateur()
        {
            Resultat *= Operande2;
        }

        /// <summary>
        /// The function "Soustraction" subtracts Operande2 from Resultat.
        /// </summary>
        public void Soustraction()
        {
            Resultat -= Operande2;
        }

        /// <summary>
        /// The function "Addition" adds the value of Operande2 to the Resultat variable.
        /// </summary>
        public void Addition()
        {
            Resultat += Operande2;
        }

        /// <summary>
        /// The Division function divides the Resultat by Operande2 using Decimal.Divide method.
        /// </summary>
        public void Division()
        {
            Resultat = Decimal.Divide(Resultat, Operande2);
        }

        /// <summary>
        /// The Reset function sets the Resultat variable to 0.
        /// </summary>
        public void Reset()
        {
            Resultat = 0;
        }
    }
}
