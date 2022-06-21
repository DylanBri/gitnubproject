using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBASIC.Functions
{
    class Arcsin : IFunction
    {
        public float Apply(List<BasicNumber> arguments)
        {
            return (float)Math.Asin(arguments[0].GetValue());
        }
    }
}
