using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperateur> _listeOperateurs = new List<IOperateur>(new Somme(), new Soustraction(), new Multiplication(), new Division());

        public decimal Calculate(string operation)
        {
            // Variable retournée pour chaque opération
            decimal _resultat = 0m;

            foreach (var operateur in _listeOperateurs)
            {
                _resultat = operateur.Calcule(operation);
            }

            return _resultat;

            ////////////////////////////////////////////

            throw new ArgumentException("Calcul impossible");
        }

    }
}