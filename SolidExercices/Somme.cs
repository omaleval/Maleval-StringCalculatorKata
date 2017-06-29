using System;

namespace SolidExercices
{
    internal class Somme : IOperateur
    {
        public char Character
        {
            get { return '+'; }
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
            catch (FormatException)
            {
                throw new ArgumentException("Impossible : Des types ne sont pas décimaux");
            }

            return _resultat;
        }

    }
}