using MathLib.Common;
using MathLib.Dtos;
using MathLib.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLib.Services
{
    public class FactorialService : IFactorialService
    {
        private FactorialDto _factorial;
        private readonly IFactorialCalculatorService _factorialCalculatorService;


        public FactorialService(FactorialDto factorial, 
            IFactorialCalculatorService factorialCalculatorService)
        {
            _factorial = factorial;
            _factorialCalculatorService = factorialCalculatorService;
        }

        public long Calculate(int _val)
        {
            if (_factorial.FactorialType == Common.GlobalConstants.FactorialWithList)
            {
                return _factorialCalculatorService.FactorialWithList(_val);
            }
            else if(_factorial.FactorialType == Common.GlobalConstants.FactorialWithRecursive)
            {
                return _factorialCalculatorService.FactorialWithRecursive(_val);
            }

            throw new InvalidOperationException($"Opration Is not Valid {Common.GlobalConstants.Factorial}");
        }

    }
}
