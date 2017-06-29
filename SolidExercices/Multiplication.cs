using System;

namespace SolidExercices
{
    internal class Multiplication : IOperateur
    {
        public char Character
        {
            get { return 'x'; }
        }
        private decimal _resultat;

        public decimal Calcule(string operation)
        {

            var calcul = operation.Split(Character);
            foreach (var nombre in calcul)
            {
                _resultat += Convert.ToDecimal(nombre);
            }

            return _resultat;
        }
    }
}