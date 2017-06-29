using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        private readonly List<IOperateur> _listeOperateurs = new List<IOperateur> { new Somme(), new Soustraction(), new Multiplication(), new Division() };

        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator(_listeOperateurs);
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASubsraction()
        {
            var calculator = new Calculator(_listeOperateurs);
            var result = calculator.Calculate("14-4,8");
            Check.That(result).IsEqualTo(9.2m);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator(_listeOperateurs);
            var result = calculator.Calculate("9x6");
            Check.That(result).IsEqualTo(54m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator(_listeOperateurs);
            var result = calculator.Calculate("5/2");
            Check.That(result).IsEqualTo(2.5m);
        }
    }
}
