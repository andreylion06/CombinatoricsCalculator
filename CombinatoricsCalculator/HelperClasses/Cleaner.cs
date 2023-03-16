using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinatoricsCalculator.HelperClasses
{
    public static class Cleaner
    {
        public static void Clean(Control mainControl)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox)!.Clear();
                    else
                        func(control.Controls);
            };

            func(mainControl.Controls);
        }
    }
}
