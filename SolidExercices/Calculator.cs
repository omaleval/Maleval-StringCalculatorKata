using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            // Variable retournée pour chaque opération
            decimal _resultat = 0m;

            if(operation.Contains('+'))
            {
                var calcul = operation.Split('+');
                    foreach (var nombre in calcul)
                    {
                        _resultat += Convert.ToDecimal(nombre);
                    }
                    return _resultat;
            }

            if (operation.Contains('-'))
            {
                var calcul = operation.Split('-');
                foreach (var nombre in calcul)
                {
                    _resultat -= Convert.ToDecimal(nombre);
                }
                return _resultat;
            }

            if (operation.Contains('*'))
            {
                var calcul = operation.Split('*');
                foreach (var nombre in calcul)
                {
                    _resultat *= Convert.ToDecimal(nombre);
                }
                return _resultat;
            }

            if (operation.Contains('/'))
            {
                var calcul = operation.Split('/');
                foreach (var nombre in calcul)
                {
                    _resultat /= Convert.ToDecimal(nombre);
                }
                return _resultat;
            }

            return _resultat;

            //throw new ArgumentException("Calcul impossible");
        }
    }
}