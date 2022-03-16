using MathLib.Dtos;
using MathLib.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Services
{
    public class SquareFactorialService : IFactorialService
    {
        private FactorialDto _factorial;
        private readonly IFactorialCalculatorService _factorialCalculatorService;


        public SquareFactorialService(FactorialDto factorial,
                  IFactorialCalculatorService factorialCalculatorService)
        {
            _factorial = factorial;
            _factorialCalculatorService = factorialCalculatorService;
        }

        public long Calculate(int _val)
        {
            if (_factorial.FactorialType == Common.GlobalConstants.SquareFactorialWithList)
            {
                return (long)Math.Pow(_factorialCalculatorService.FactorialWithList(_val), 2);

            }
            else if (_factorial.FactorialType == Common.GlobalConstants.SquareFactorialWithRecursive)
            {
                return (long)Math.Pow(_factorialCalculatorService.FactorialWithRecursive(_val), 2);
            }

            throw new InvalidOperationException($"Opration Is not Valid {Common.GlobalConstants.SquareFactorial}");

        }



    }
}
