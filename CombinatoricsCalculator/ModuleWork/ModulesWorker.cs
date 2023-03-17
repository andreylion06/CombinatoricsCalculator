using CombinatoricsCalculator.ExpressionModules;

namespace CombinatoricsCalculator.Module
{
    public static class ModulesWorker
    {
        private static List<ModuleWrapper> functions = new List<ModuleWrapper>
        {
            new ModuleWrapper("Placement Without Repeats", new PlacementWithoutRep()),
            new ModuleWrapper("Placement With Repeats", new PlacementWithRep()),
            new ModuleWrapper("Combination Without Repeats", new CombinationWithoutRep()),
            new ModuleWrapper("Combination With Repeats", new CombinationWithRep()),
            new ModuleWrapper("Permutation Without Repeats", new PermutationWithoutRep()),
            new ModuleWrapper("Permutation With Repeats", new PermutationWithRep())
        };
        public static ExpressionModule GetModuleByName(string name)
        {
            var calcFunction = functions.Where(func => func.Name == name).FirstOrDefault();
            return calcFunction != null ? calcFunction.Module! : null;
        }
        public static List<string> GetListOfModules()
        {
            return functions.Select(func => func.Name).ToList();
        }

    }
}