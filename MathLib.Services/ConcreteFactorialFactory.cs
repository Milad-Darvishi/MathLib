using MathLib.Dtos;
using MathLib.Services.Contracts;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Services
{
    public class ConcreteFactorialFactory : FactorialFactoryService
    {
        private IFactorialCalculatorService _factorialService;
        private readonly IServiceProvider _serviceProvider;

        public ConcreteFactorialFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(_serviceProvider));

        }

        public override IFactorialService GetFactorial(FactorialDto factorial)
        {

            _factorialService = _serviceProvider.GetService<IFactorialCalculatorService>();

            switch (factorial.FactorialName)
            {
                case "Factorial":
                    return new FactorialService(factorial, _factorialService);

                case "UnevenFactorial":
                    return new UnevenFactorialService(factorial, _factorialService);

                case "SquareFactorial":
                    return new SquareFactorialService(factorial, _factorialService);

                default:
                    throw new ApplicationException(string.Format("Factorial '{0}' cannot be created", factorial));
            }
        }
    }
}
