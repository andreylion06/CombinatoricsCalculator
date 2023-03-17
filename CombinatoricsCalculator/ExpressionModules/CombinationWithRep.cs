using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class CombinationWithRep : ExpressionModule
    {
        public CombinationWithRep()
        {
            this.control = new CombinationControl("C");
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.CombinationWithRep(args["n"][0], args["k"][0]);
        }
    }
}
