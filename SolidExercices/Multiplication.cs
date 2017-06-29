using System;
using System.Linq;

namespace SolidExercices
{
    public class Multiplication : IOperateur
    {
        public char Character
        {
            get { return 'x'; }
        }
        private decimal _resultat;

        public decimal Calcule(string operation)
        {

            var calcul = operation.Split(Character);
            var _resultat = Convert.ToDecimal(calcul[0]);

            foreach (var nombre in calcul.Skip(1))
            {
                _resultat *= Convert.ToDecimal(nombre);
            }

            return _resultat;
        }
    }
}