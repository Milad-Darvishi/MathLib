using MathLib.Services;
using MathLib.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLib.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        private  IFactorialService _factorialService;

        [TestMethod]
        public void Four_Factorial_With_Recursive_must_be_TwentyFour()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.Factorial, FactorialType = Common.GlobalConstants.FactorialWithRecursive });

            long result = factorial_model.Calculate(4);

            Assert.AreEqual(24, result);
        }


        [TestMethod]
        public void Four_Factorial_With_List_Must_be_TwentyFour()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.Factorial , FactorialType = Common.GlobalConstants.FactorialWithList });

            long result = factorial_model.Calculate(4);

            Assert.AreEqual(24, result);
        }


        [TestMethod]
        public void Square_Factorial_Factorial__With_List_Must_be_Fivehundred_and_seventysix()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.SquareFactorial ,
                FactorialType = Common.GlobalConstants.SquareFactorialWithList });

            long result = factorial_model.Calculate(4);

            Assert.AreEqual(576, result);
        }

        
        [TestMethod]
        public void Square_Factorial_Four_With_Recursive_Must_be_Fivehundred_and_seventysix()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.SquareFactorial, 
                FactorialType = Common.GlobalConstants.SquareFactorialWithRecursive });

            long result = factorial_model.Calculate(4);

            Assert.AreEqual(576, result);
        }



        [TestMethod]
        public void Eight_UnevenFactorial_With_Recursive_Must_be_Onehundred_and_Five()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            { FactorialName = Common.GlobalConstants.UnevenFactorial,
                FactorialType = Common.GlobalConstants.UnevenFactorialWithRecursive });

            long result = factorial_model.Calculate(8);

            Assert.AreEqual(105, result);
        }

        [TestMethod]
        public void Eight_UnevenFactorial_With_List_Must_be_Onehundred_and_Five()
        {
            var services = new ServiceCollection();
            services.AddScoped<IFactorialCalculatorService, FactorialCalculatorService>();


            var serviceProvider = services.BuildServiceProvider();

            var _model = new ConcreteFactorialFactory(serviceProvider);

            var factorial_model = _model.GetFactorial(new Dtos.FactorialDto
            {
                FactorialName = Common.GlobalConstants.UnevenFactorial,
                FactorialType = Common.GlobalConstants.UnevenFactorialWithList
            });

            long result = factorial_model.Calculate(8);

            Assert.AreEqual(105, result);
        }

    }
}
