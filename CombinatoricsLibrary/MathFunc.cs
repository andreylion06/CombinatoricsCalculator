
namespace CombinatoricsLibrary
{
    public static class MathFunc
    {
        public static long Factorial(long n)
        {
            NumberValidator.FactorialArgument(n);
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        public static long IntPower(int n, int power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
                result *= n;
            return result;
        }
    }
}
