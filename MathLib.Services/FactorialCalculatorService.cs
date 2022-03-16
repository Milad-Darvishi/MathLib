using MathLib.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLib.Services
{
    public class FactorialCalculatorService : IFactorialCalculatorService
    {
        public long FactorialWithList(int i, bool isUnEven = false)
        {

            if (i == 0)
            {
                return 1;
            }

            if (isUnEven)
            {

                return i < 0 ? -1 : i == 0 || i == 1 ? 1 : Enumerable.Range(1, i).Where(number => number % 2 == 1).Aggregate((counter, value) => counter * value);

            }
            else
            {

                return i < 0 ? -1 : i == 0 || i == 1 ? 1 : Enumerable.Range(1, i).Aggregate((counter, value) => counter * value);
            }

        }

        public long FactorialWithRecursive(int i, bool isUnEven = false)
        {
            if (i <= 0)
            {
                return 1;
            }

            if (isUnEven)
            {
                if ((i % 2) == 0)
                {
                    i = i - 1;
                }
                return i * FactorialWithRecursive(i - 2, true);
            }
            else
            {

                return i * FactorialWithRecursive(i - 1);
            }



        }
    }
}
