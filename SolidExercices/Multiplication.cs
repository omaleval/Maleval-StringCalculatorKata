using System;
using System.Linq;

namespace SolidExercices
{
    internal class Multiplication : IOperateur
    {
        private decimal _resultat;

        public decimal Calcule(string operation)
        {
            if (operation.Contains('*'))
            {
                var calcul = operation.Split('*');
                foreach (var nombre in calcul)
                {
                    _resultat += Convert.ToDecimal(nombre);
                }
            }
            return _resultat;
        }
    }
}