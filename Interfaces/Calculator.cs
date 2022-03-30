using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Calculator : ICalculator, ISientificCalculator
    {
        int ICalculator.CalcSum(int a, int b)
        {
            throw new NotImplementedException();
        }

        int ISientificCalculator.CalcSum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
