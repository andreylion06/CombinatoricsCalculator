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
            if (power == 0) return 1;
            if (power == 1) return n;

            return Enumerable
              .Repeat(n,power)
              .Aggregate(1, (a, b) => a * b);
        }
    }
}
