using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperateur> _listeOperateurs = new List<IOperateur> { new Somme(), new Soustraction(), new Multiplication(), new Division() };
        public char Character;

        public decimal Calculate(string operation)
        {
            // Variable retournée pour chaque opération
            decimal _resultat = 0m;

            foreach (var operateur in _listeOperateurs)
            {
                if (operation.Contains(Character))
                {
                    _resultat = operateur.Calcule(operation);
                }
                
            }
            return _resultat;
           
        }

    }
}