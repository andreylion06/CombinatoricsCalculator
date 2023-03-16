using CombinatoricsCalculator.ExpressionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator
{
    public class CalculatorModule
    {
        public string Name { get; set; }
        public ExpressionModule? Module { get; set; }
        public CalculatorModule(string name, ExpressionModule? module)
        {
            Name = name;
            Module = module;
        }
    }
}
