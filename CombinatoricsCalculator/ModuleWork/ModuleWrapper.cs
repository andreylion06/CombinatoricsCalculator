using CombinatoricsCalculator.ExpressionModules;

namespace CombinatoricsCalculator.Module
{
    public class ModuleWrapper
    {
        public string Name { get; set; }
        public ExpressionModule? Module { get; set; }
        public ModuleWrapper(string name, ExpressionModule? module)
        {
            Name = name;
            Module = module;
        }
    }
}
