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
    public partial class LetterCombonent : UserControl, IExpressionComponent
    {
        public LetterCombonent(CombName combName)
        {
            InitializeComponent();

            CombName = combName;
            this.SetLetter();
        }

        public CombName CombName { get; private set; }

        private void SetLetter()
        {
            if (CombName == CombName.PlacementWithoutRep)
                label_Letter.Text = "A";
            else if(CombName == CombName.CombinationWithoutRep ||
                CombName == CombName.CombinationWithRep)
                label_Letter.Text = "C";
        }

        public void TryGetArguments(out Dictionary<string, int[]> res)
        {
           int k = Int32.Parse(textBox_k.Text);
           int n = Int32.Parse(textBox_n.Text);
           
           if(k > n)
            {
                string tmp = textBox_k.Text;
                textBox_k.Text = textBox_n.Text;
                textBox_n.Text = tmp;
            }

           res = new Dictionary<string, int[]> { 
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
