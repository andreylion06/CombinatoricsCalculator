using CombinatoricsCalculator.HelperClasses;
using CombinatoricsCalculator.UserControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator.ExpressionModules
{
    public abstract class ExpressionModule
    {
        protected ExpressionControl? control { get; set; }
        public UserControl LoadUserControl()
        {
            Cleaner.Clean(control!);
            return control!;
        }
        public abstract void TryCount(out long res);

    }
}
