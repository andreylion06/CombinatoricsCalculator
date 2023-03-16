using CombinatoricsCalculator.ExpressionModules;
using CombinatoricsCalculator.UserControlls;

namespace CombinatoricsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        PlacementWithoutRep pl = new PlacementWithoutRep();

        private void button_Count_Click(object sender, EventArgs e)
        {
            long res;
            pl.TryCount(out res);
            textBox1.Text = res.ToString();
        }

        private void comboBox_CombName_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox_Expression.Controls.Add(pl.LoadUserControl());
        }
    }
}