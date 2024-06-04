using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine(calc.Sum(5, 5));
            Console.WriteLine(calc.Sum(-5, -5));

            Console.WriteLine(calc.Subtract(5, 5));
            Console.WriteLine(calc.Subtract(-5, 5));
            Console.WriteLine(calc.Subtract(-5, -5));

            Console.WriteLine(calc.Multiply(5, 5));

            Console.WriteLine(calc.Divide(6, 2));

        }
    }
}