using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class PlacementWithoutRep : ExpressionModule
    {
        public PlacementWithoutRep()
        {
            this.control = new CombinationControl("A");
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.PlacementWithoutRep(args["n"][0], args["k"][0]);
        }
    }
}
