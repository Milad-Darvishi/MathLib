using MathLib.Services;
using MathLib.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MathLib
{
    class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI for SquareFactorial as sample
            var serviceProvider = new ServiceCollection()
                .AddScoped<IFactorialService, SquareFactorialService>()
                .AddScoped<IFactorialCalculatorService, FactorialCalculatorService>()
                .BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var x = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.UnevenFactorial,FactorialType= Common.GlobalConstants.UnevenFactorialWithList });

            var s = x.Calculate(8);

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
