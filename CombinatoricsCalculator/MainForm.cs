using CombinatoricsCalculator.UserControlls;

namespace CombinatoricsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void button_Count_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_CombName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_CombName.SelectedItem.ToString() == "Placement Without Repeats")
            {
                LetterCombonent letterCombonent = new LetterCombonent(CombName.PlacementWithoutRep);
                groupBox_Expression.Controls.Add(letterCombonent);
            }
            else if (comboBox_CombName.SelectedItem.ToString() == "Combination Without Repeats")
            {
                LetterCombonent letterCombonent = new LetterCombonent(CombName.CombinationWithoutRep);
                groupBox_Expression.Controls.Add(letterCombonent);
            }
            else if (comboBox_CombName.SelectedItem.ToString() == "Combination With Repeats")
            {
                LetterCombonent letterCombonent = new LetterCombonent(CombName.CombinationWithRep);
                groupBox_Expression.Controls.Add(letterCombonent);
            }


            //Placement Without Repeats
            //Placement With Repeats
            //Combination Without Repeats
            //Combination With Repeats
            //Permutation Without Repeats
            //Permutation With Repeats
        }
    }
}