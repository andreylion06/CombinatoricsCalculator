using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombinatoricsCalculator.HelperClasses;

namespace CombinatoricsCalculator.UserControlls
{
    public partial class LetterControl : ExpressionControl
    {
        public LetterControl(string letter)
        {
            InitializeComponent();

            label_Letter.Text = letter;
        }


        public override Dictionary<string, int[]> GetArguments()
        {
            if (textBox_k.Text.Length == 0)
                textBox_k.Text = "1";
            if (textBox_n.Text.Length == 0)
                textBox_n.Text = "1";

            int k = int.Parse(textBox_k.Text);
            int n = int.Parse(textBox_n.Text);
            
            if (k > n)
            {
                string tmp = textBox_k.Text;
                textBox_k.Text = textBox_n.Text;
                textBox_n.Text = tmp;
            }

            return new Dictionary<string, int[]> {
               { "n", new int[] { n } },
               { "k", new int[] { k } }
           };
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox)!.Validate(TextValidator.ValidationType.Integer, 3);
        }
    }
}
