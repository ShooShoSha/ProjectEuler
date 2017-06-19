using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerLibrary
{
    public static class Math
    {
        public static int Fibonacci(int nthValue)
        {
            if (nthValue <= 1)
            {
                return 0;
            }
            else if (nthValue == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(nthValue - 1) + Fibonacci(nthValue - 2);
            }
        }
    }
}
