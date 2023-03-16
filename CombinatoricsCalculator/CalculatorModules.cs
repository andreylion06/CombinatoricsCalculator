using CombinatoricsCalculator.ExpressionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator
{
    public static class CalculatorModules
    {
        private static List<CalculatorModule> functions = new List<CalculatorModule>
        {
            new CalculatorModule("Placement Without Repeats", new PlacementWithoutRep()),
            new CalculatorModule("Placement With Repeats", new PlacementWithoutRep()),
            new CalculatorModule("Combination Without Repeats", new CombinationWithoutRep()),
            new CalculatorModule("Combination With Repeats", new CombinationWithRep()),
            new CalculatorModule("Permutation Without Repeats", new PlacementWithoutRep()),
            new CalculatorModule("Permutation With Repeats", new PlacementWithoutRep())
        };
        public static ExpressionModule GetModuleByName(string name)
        {
            var calcFunction = functions.Where(func => func.Name == name).FirstOrDefault();
            return (calcFunction != null) ? calcFunction.Module! : null;
        }
        public static List<string> GetListOfModules()
        {
            return functions.Select(func => func.Name).ToList();
        }

    }
}