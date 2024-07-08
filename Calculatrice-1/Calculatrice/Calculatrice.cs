namespace Calculatrice_1.Calculatrice
{
    public class Calculatrice
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
            Resultat = Decimal.Divide(Resultat, Operande2);
        }
        public void Reset()
        {
            Resultat = 0;
        }
    }
}
