using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class PermutationWithRep : ExpressionModule
    {
        public PermutationWithRep()
        {
            this.control = new PermutationControl();
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            if (args.ContainsKey("exception"))
                res = 0;
            else
                res = Combinatorics.PermutationWithRep(args["n"][0], args["k"]);
        }
    }
}
