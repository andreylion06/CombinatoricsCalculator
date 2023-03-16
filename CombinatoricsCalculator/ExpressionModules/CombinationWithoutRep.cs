﻿using CombinatoricsCalculator.UserControlls;
using CombinatoricsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinatoricsCalculator.ExpressionModules
{
    public class CombinationWithoutRep : ExpressionModule
    {
        public CombinationWithoutRep()
        {
            this.control = new LetterControl("C");
        }
        public override void TryCount(out long res)
        {
            Dictionary<string, int[]> args = control!.GetArguments();
            res = Combinatorics.CombinationWithoutRep(args["n"][0], args["k"][0]);
        }
    }
}