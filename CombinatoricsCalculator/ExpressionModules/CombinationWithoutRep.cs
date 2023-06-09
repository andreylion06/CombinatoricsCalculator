﻿using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class CombinationWithoutRep : ExpressionModule
    {
        public CombinationWithoutRep()
        {
            this.control = new CombinationControl("C");
        }
        public override void TryCount(out decimal res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.CombinationWithoutRep(args["n"][0], args["k"][0]);
        }
    }
}
