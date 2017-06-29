using System;

namespace SolidExercices
{
    internal class Division : IOperateur
    {
        public char Character
        {
            get { return '/'; }
        }
        private decimal _resultat;

        public decimal Calcule(string operation)
        {

            var calcul = operation.Split(Character);
            try
            {
                foreach (var nombre in calcul)
                {
                    _resultat += Convert.ToDecimal(nombre);
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