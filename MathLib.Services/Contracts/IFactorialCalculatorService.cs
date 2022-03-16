using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Services.Contracts
{
    public interface IFactorialCalculatorService
    {
        long FactorialWithRecursive(int i, bool isUnEven = false);
        long FactorialWithList(int i, bool isUnEven = false);
    }
}
