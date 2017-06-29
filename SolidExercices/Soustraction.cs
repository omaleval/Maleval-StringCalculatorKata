using System;
using System.Linq;

namespace SolidExercices
{
    internal class Soustraction : IOperateur
    {
        public char Character = '-';
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