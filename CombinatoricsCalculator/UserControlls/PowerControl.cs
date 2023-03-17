using CombinatoricsCalculator.HelperClasses;

namespace CombinatoricsCalculator.UserControlls
{
    public partial class PowerControl : ExpressionControl
    {
        public PowerControl()
        {
            InitializeComponent();
        }

        public override Dictionary<string, int[]> GetArguments()
        {
            if (textBox_Base.Text.Length == 0)
                textBox_Base.Text = "1";
            if (textBox_Power.Text.Length == 0)
                textBox_Power.Text = "1";

            int n = int.Parse(textBox_Base.Text);
            int k = int.Parse(textBox_Power.Text);

            TextBoxWorker.Readonly(this);

            return new Dictionary<string, int[]> {
               { "n", new int[] { n } },
               { "k", new int[] { k } }
           };
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox)!.Validate(TextValidator.ValidationType.Integer, 2);
        }
    }
}
