using MathLib.Dtos;
using MathLib.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Services
{
    public class UnevenFactorialService : IFactorialService
    {

        private FactorialDto _factorial;
        private readonly IFactorialCalculatorService _factorialCalculatorService;


        public UnevenFactorialService(FactorialDto factorial,
            IFactorialCalculatorService factorialCalculatorService)
        {
            _factorial = factorial;
            _factorialCalculatorService = factorialCalculatorService;


        }
        public long Calculate(int _val)
        {

            if (_factorial.FactorialType == Common.GlobalConstants.UnevenFactorialWithList)
            {
                return _factorialCalculatorService.FactorialWithList(_val, true);
            }
            else if (_factorial.FactorialType == Common.GlobalConstants.UnevenFactorialWithRecursive)
            {
                return _factorialCalculatorService.FactorialWithRecursive(_val, true);
            }
            throw new InvalidOperationException($"Opration Is not Valid {Common.GlobalConstants.UnevenFactorial}");


        }
    }
}
