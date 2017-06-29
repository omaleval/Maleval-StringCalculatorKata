using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        public void CalculateASubsraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("14-4,8");
            Check.That(result).IsEqualTo(9.2m);
        }

        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("9*6");
            Check.That(result).IsEqualTo(54m);
        }

        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5/2");
            Check.That(result).IsEqualTo(2.5m);
        }
    }
}
