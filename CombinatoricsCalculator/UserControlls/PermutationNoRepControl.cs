using CombinatoricsCalculator.HelperClasses;

namespace CombinatoricsCalculator.UserControlls
{
    public partial class PermutationNoRepControl : ExpressionControl
    {
        public PermutationNoRepControl()
        {
            InitializeComponent();
        }

        public override Dictionary<string, int[]> GetArguments()
        {
            if (textBox_n.Text.Length == 0)
                textBox_n.Text = "1";

            int n = int.Parse(textBox_n.Text);

            TextBoxWorker.Readonly(this);

            return new Dictionary<string, int[]> {
               { "n", new int[] { n } }
           };
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox)!.Validate(TextValidator.ValidationType.Integer, 2);
        }
    }
}
