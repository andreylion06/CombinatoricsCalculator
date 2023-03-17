using CombinatoricsCalculator.ExpressionModules;
using CombinatoricsCalculator.Module;

namespace CombinatoricsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            comboBox_CombName.DataSource = ModulesWorker.GetListOfModules();
        }

        ExpressionModule? currentModule;

        private void button_Count_Click(object sender, EventArgs e)
        {
            if (currentModule != null)
            {
                decimal res;
                currentModule.TryCount(out res);
                textBox_Result.Text = res.ToString();
                button_Reset.Visible = true;
            }
        }

        private void comboBox_CombName_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentModule = ModulesWorker.GetModuleByName(comboBox_CombName.SelectedItem.ToString()!);
            groupBox_Expression.Controls.Clear();
            groupBox_Expression.Controls.Add(currentModule.LoadUserControl());

            SetFormToDefault();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            SetFormToDefault();
        }

        private void SetFormToDefault()
        {
            currentModule!.UnReadonlyFields();
            textBox_Result.Text = "0";
            button_Reset.Visible = false;
        }
    }
}