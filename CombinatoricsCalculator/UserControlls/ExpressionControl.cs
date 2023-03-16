using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator.UserControlls
{
    public abstract class ExpressionControl : UserControl
    {
        public abstract Dictionary<string, int[]> GetArguments();
    }
}
