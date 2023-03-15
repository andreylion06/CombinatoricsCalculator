namespace CombinatoricsLibrary
{
    public class Combinatorics
    {
        public static long PlacementWithoutRep(int n, int k)
        {
            NumberValidator.FirstGreaterEquals(ref n, ref k);
            return MathFunc.Factorial(n) / MathFunc.Factorial(n - k);
        }
        public static long PlacementWithRep(int n, int k)
        {
            return MathFunc.IntPower(n, k);
        }
        public static long CombinationWithoutRep(int n, int k)
        {
            NumberValidator.FirstGreaterEquals(ref n, ref k);
            return MathFunc.Factorial(n) / (MathFunc.Factorial(k) * MathFunc.Factorial(n - k));
        }
        public static long CombinationWithRep(int n, int k)
        {
            NumberValidator.FirstGreaterEquals(ref n, ref k);
            return MathFunc.Factorial(n + k - 1) / (MathFunc.Factorial(n - 1) * MathFunc.Factorial(k));
        }
        public static long PermutationWithoutRep(int n)
        {
            return MathFunc.Factorial(n);
        }
        public static long PermutationWithRep(int n, int[] k)
        {
            NumberValidator.ArrayEmpty(k);
            
            long denominator = 1;
            foreach(int item in k)
                denominator *= MathFunc.Factorial(item);
            
            return MathFunc.Factorial(n) / denominator;
        }
    }
}