namespace Calculatrice_1.Calculatrice
{
    /// <summary>
    /// La classe <c>Calculatrice</c> permet d'éffectuer des opérations.
    /// </summary>
    public class Calculatrice
    {
        
        public decimal Operande2 { get; set; }
        public decimal Resultat { get; set; }

        /// <summary>
        /// La méthode <c>Multiplicateur</c> effectue une multiplication de l'attribut Resultat et Operande2.
        /// </summary>
        public void Multiplicateur()
        {
            Resultat *= Operande2;
        }

        /// <summary>
        /// La méthode <c>Soustraction</c> effectue une soustraction de l'attribut Resultat et Operande2.
        /// </summary>
        public void Soustraction()
        {
            Resultat -= Operande2;
        }

        /// <summary>
        /// La méthode <c>Addition</c> effectue une addition de l'attribut Resultat et Operande2.
        /// </summary>
        public void Addition()
        {
            Resultat += Operande2;
        }

        /// <summary>
        /// La méthode <c>Division</c> effectue une division de l'attribut Resultat par Opérande2.
        /// </summary>
        public void Division()
        {
            Resultat = Decimal.Divide(Resultat, Operande2);
        }

        /// <summary>
        /// La méthode <c>Reset</c> reinitialise la valeur de Resultat de notre calculatrice.
        /// </summary>
        public void Reset()
        {
            Resultat = 0;
        }
    }
}
