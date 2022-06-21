using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    class SolveLinear : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {      

            if (arguments[0] == 0 && arguments[1] != 0)
            {
                throw new NullReferenceException();               
            }
            else if (arguments[0] == 0 && arguments[1] == 0)
            {
                return float.NaN;
            }
            else
            {
                return -arguments[1] / arguments[0];
            }
        }
    }
}
