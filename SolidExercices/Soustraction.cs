using System;
using System.Linq;

namespace SolidExercices
{
    public class Soustraction : IOperateur
    {
        public char Character
        {
            get { return '-'; }
        }
      

        public decimal Calcule(string operation)
        {
            var calcul = operation.Split(Character);
            var resultat = Convert.ToDecimal(calcul[0]);

            foreach (var nombre in calcul.Skip(1))
            {
                resultat -= Convert.ToDecimal(nombre);
            }

            return resultat;
        }

    }
}