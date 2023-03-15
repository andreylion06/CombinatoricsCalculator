using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsLibrary
{
    public static class NumberValidator
    {
        public static void FirstGreaterEquals(ref int a1, ref int a2)
        {
            if(a1 < a2)
                (a1, a2) = (a2, a1);
        }
        public static void ArrayEmpty(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Array with reps must have at least 1 element.");
        }
        public static void FactorialArgument(long n)
        {
            if (n < 0)
                throw new ArgumentException("The factorial argument must be => 0.");
        }
    }
}
