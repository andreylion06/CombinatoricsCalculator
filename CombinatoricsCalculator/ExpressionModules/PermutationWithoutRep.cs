using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class PermutationWithoutRep : ExpressionModule
    {
        public PermutationWithoutRep()
        {
            this.control = new PermutationNoRepControl();
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.PermutationWithoutRep(args["n"][0]);
        }
    }
}
