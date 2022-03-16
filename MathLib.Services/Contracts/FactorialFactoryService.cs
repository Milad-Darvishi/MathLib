using MathLib.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Services.Contracts
{
    public abstract class FactorialFactoryService
    {
        public abstract IFactorialService GetFactorial(FactorialDto factorial);
    }
}
