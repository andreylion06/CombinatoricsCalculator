using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class PlacementWithRep : ExpressionModule
    {
        public PlacementWithRep()
        {
            this.control = new PowerControl();
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.PlacementWithRep(args["n"][0], args["k"][0]);
        }
    }
}
