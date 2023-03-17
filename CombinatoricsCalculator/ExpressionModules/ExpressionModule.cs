using CombinatoricsCalculator.HelperClasses;
using CombinatoricsCalculator.UserControlls;

namespace CombinatoricsCalculator.ExpressionModules
{
    public abstract class ExpressionModule
    {
        protected ExpressionControl? control { get; set; }
        public UserControl LoadUserControl()
        {
            TextBoxWorker.Clean(control!);
            return control!;
        }
        public void UnReadonlyFields()
        {
            TextBoxWorker.UnReadonly(control!);
        }
        public abstract void TryCount(out decimal res);

    }
}
