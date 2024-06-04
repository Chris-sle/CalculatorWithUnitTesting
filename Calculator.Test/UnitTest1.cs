using Calculator;

namespace Calculator.Test
{
    public class Tests
    {
        
        [Test]
        public void TestSum()
        {
            var calc = new Calculator();
            Assert.That(calc.Sum(5, 5), Is.EqualTo(10));
            Assert.That(calc.Sum(-5, -5), Is.EqualTo(-10));
        }

        [Test]
        public void TestSubtract()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtract(5, 5), Is.EqualTo(0));
            Assert.That(calc.Subtract(-5, 5), Is.EqualTo(-10));
            Assert.That(calc.Subtract(-5, -5), Is.EqualTo(0));
        }

        [Test]
        public void TestMultiply()
        {
            var calc = new Calculator();
            Assert.That(calc.Multiply(5, 5), Is.EqualTo(25));
        }

        [Test]
        public void TestDivide()
        {
            var calc = new Calculator();
            Assert.That(calc.Divide(6, 2), Is.EqualTo(3));
        }
    }
}