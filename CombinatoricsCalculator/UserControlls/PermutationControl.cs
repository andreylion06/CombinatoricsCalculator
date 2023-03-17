using CombinatoricsCalculator.HelperClasses;

namespace CombinatoricsCalculator.UserControlls
{
    public partial class PermutationControl : ExpressionControl
    {
        public PermutationControl()
        {
            InitializeComponent();
        }

        public override Dictionary<string, int[]> GetArguments()
        {
            if (textBox_n.Text.Length == 0)
                textBox_n.Text = "1";
            if (textBox_k.Text.Length == 0)
            {
                textBox_k.Text = "1";
                textBox_n.Text = "1";
            }

            int n = int.Parse(textBox_n.Text);
            int[] k = new int[] { };
            try
            {
                k = Array.ConvertAll(textBox_k.Text.Trim().Split(", "), Convert.ToInt32);
            }
            catch (Exception ex) { }

            Dictionary<string, int[]> res;
            if(k.Length == 0)
            {
                res = new Dictionary<string, int[]>()
                {
                    { "exception", new int[] { 1 } }
                };
                MessageBox.Show("Exception", "Incorrect values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextBoxWorker.Readonly(this);
                res = new Dictionary<string, int[]> {
                   { "n", new int[] { n } },
                   { "k", k }
               };
            }

            return res;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox)!.Validate(TextValidator.ValidationType.Integer, 2);
        }
    }
}
