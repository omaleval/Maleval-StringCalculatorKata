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
            foreach (var nombre in calcul)
            {
                _resultat += Convert.ToDecimal(nombre);
            }

            return _resultat;
        }
    }
}