using System;
using System.Linq;

namespace SolidExercices
{
    public class Division : IOperateur
    {
        public char Character
        {
            get { return '/'; }
        }
        private decimal _resultat;

        public decimal Calcule(string operation)
        {

            var calcul = operation.Split(Character);
            var _resultat = Convert.ToDecimal(calcul[0]);

            try
            {
                foreach (var nombre in calcul.Skip(1))
                {
                    _resultat /= Convert.ToDecimal(nombre);
                }
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("Impossible : Division par 0!");
            }


            return _resultat;
        }
    }
}