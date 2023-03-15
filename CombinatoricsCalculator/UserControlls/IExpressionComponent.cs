using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator.UserControlls
{
    public interface IExpressionComponent
    {
        CombName CombName { get; }
        void TryGetArguments(out Dictionary<string, int[]> res);
    }
}
