using CombinatoricsCalculator.ExpressionModules;
using CombinatoricsCalculator.UserControlls;

namespace CombinatoricsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            comboBox_CombName.DataSource = CalculatorModules.GetListOfModules();
        }

        ExpressionModule? currentModule;

        private void button_Count_Click(object sender, EventArgs e)
        {
            if (currentModule != null)
            {
                long res;
                currentModule.TryCount(out res);
                textBox1.Text = res.ToString();
            }
        }

        private void comboBox_CombName_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentModule = CalculatorModules.GetModuleByName(comboBox_CombName.SelectedItem.ToString()!);
            groupBox_Expression.Controls.Clear();
            groupBox_Expression.Controls.Add(currentModule.LoadUserControl());
        }
    }
}