using System;
using System.Collections.Generic;

namespace DerivateCalculatorConsoleApp
{
    class Program
    {
        static void Main()
        {
            // 3x^2 + 5x + 2
            var term1 = new Term {Coeff = 3, Exponent = 2};
            var term2 = new Term {Coeff = 5, Exponent = 1};
            var term3 = new Term {Coeff = 2, Exponent = 0};
            var equation = new[] { term1, term2, term3};

            var calculator = new DerivativeCalculator();
            List<Term> results = calculator.Derivate(equation);

            foreach (Term term in results)
            {
                Console.Write("{0}x^{1}", term.Coeff, term.Exponent);
                Console.Write(term.Coeff >= 0 ? " + ": " - ");
            }
            Console.WriteLine();

            Console.WriteLine("Expected");
            Console.WriteLine("6x^1 + 5x^0");
        }
    }
}
