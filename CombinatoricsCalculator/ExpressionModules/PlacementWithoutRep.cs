using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class PlacementWithoutRep : ExpressionModule
    {
        public PlacementWithoutRep()
        {
            this.control = new LetterControl("A");
        }
        public override void TryCount(out long res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.PlacementWithoutRep(args["n"][0], args["k"][0]);
        }
    }
}
