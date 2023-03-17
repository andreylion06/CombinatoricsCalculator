
namespace CombinatoricsCalculator.HelperClasses
{
    public static class TextBoxWorker
    {
        private static void GoThrough(Control mainControl, Action<TextBox> action)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        action((control as TextBox)!);
                    else
                        func(control.Controls);
            };

            func(mainControl.Controls);
        }
        public static void Clean(Control mainControl)
        {
            GoThrough(mainControl, control => control.Clear());
        }
        public static void Readonly(Control mainControl)
        {
            GoThrough(mainControl, control => control.ReadOnly = true);
        }
        public static void UnReadonly(Control mainControl)
        {
            GoThrough(mainControl, control => control.ReadOnly = false);
        }
    }
}