using System.Collections.Generic;

namespace DerivateCalculatorConsoleApp
{
    class DerivativeCalculator
    {
        public List<Term> Derivate(Term[] equation)
        {
            var results = new List<Term>();
            foreach (Term term in equation)
            {
                if (term.Exponent == 0)
                {
                    continue;
                }

                var result = new Term();
                result.Exponent = term.Exponent - 1;
                result.Coeff = term.Exponent*term.Coeff;
                results.Add(result);
            }

            return results;
        }
    }
}