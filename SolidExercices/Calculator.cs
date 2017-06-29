using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperateur> _listeOperateurs;

        public Calculator(List<IOperateur> listeOperateurs)
        {
            _listeOperateurs = listeOperateurs;
        }

        public decimal Calculate(string operation)
        {
            // Variable retournée pour chaque opération

            foreach (var operateur in _listeOperateurs)
            {
               if (operation.Contains(operateur.Character))
               {
                    return operateur.Calcule(operation);
               } 
            }
           
            throw new ArgumentException("Impossible : Aucune opération n'est valable");
        }

    }
}